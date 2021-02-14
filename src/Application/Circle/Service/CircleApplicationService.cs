using System;
using System.Transactions;

public class CircleApplicationService
{
    private readonly ICircleFactory circleFactory;
    private readonly ICircleRepository circleRepository;
    private readonly ICircleInvitationRepository circleInvitationRepository;
    private readonly CircleService circleService;
    private readonly IUserRepository userRepository;
    
    public CircleApplicationService(
        ICircleFactory circleFactory,
        ICircleRepository circleRepository,
        ICircleInvitationRepository circleInvitationRepository,
        CircleService circleService,
        IUserRepository userRepository
    ) {
        this.circleFactory              = circleFactory;
        this.circleRepository           = circleRepository;
        this.circleInvitationRepository = circleInvitationRepository;
        this.circleService              = circleService;
        this.userRepository             = userRepository;
    }
    
    public void Create(CircleCreateCommand command)
    {
        using (var transaction = new TransactionScope())
        {
            var ownerId = new UserId(command.UserId);
            var owner   = userRepository.Find(ownerId);

            if (owner == null)
            {
                throw new Exception("サークルのオーナーとなるユーザーが見つかりませんでした。");
            }

            var name   = new CircleName(command.Name);
            var circle = circleFactory.Create(name, owner);

            if (circleService.Exists(circle))
            {
                throw new Exception("サークルは既に存在しています。");
            }

            circleRepository.Save(circle);

            transaction.Complete();
        }
    }

    public void Join(CircleJoinCommand command)
    {
        using (var transaction = new TransactionScope())
        {
            var memberId = new UserId(command.UserId);
            var member   = userRepository.Find(memberId);

            if (member == null)
            {
                throw new Exception("ユーザーが見つかりませんでした。");
            }

            var circleId = new CircleId(command.CircleId);
            var circle   = circleRepository.Find(circleId);

            if (circle == null)
            {
                throw new Exception("サークルが見つかりませんでした。");
            }

            var owner          = userRepository.Find(circle.Owner.Id);
            var circleMembers  = new CircleMembers(circle.Id, owner, circle.Members);
            var circleFullSpec = new CircleMembersFullSpecification();

            if (circleFullSpec.IsSatisfiedBy(circleMembers))
            {
                throw new Exception("サークルが規定人数に達しています。");
            }

            circle.Join(member);
            circleRepository.Save(circle);

            transaction.Complete();
        }
    }

    public void Invite(CircleInviteCommand command)
    {
        using (var transaction = new TransactionScope())
        {
            var fromUserId = new UserId(command.FromUserId);
            var fromUser   = userRepository.Find(fromUserId);

            if (fromUser == null)
            {
                throw new Exception("招待元ユーザーが見つかりませんでした。");
            }

            var invitedUserId = new UserId(command.InvitedUserId);
            var invitedUser   = userRepository.Find(invitedUserId);

            if (invitedUser == null)
            {
                throw new Exception("招待先ユーザーが見つかりませんでした。");
            }

            var circleId = new CircleId(command.CircleId);
            var circle   = circleRepository.Find(circleId);

            if (circle == null)
            {
                throw new Exception("サークルが見つかりませんでした。");
            }

            var owner          = userRepository.Find(circle.Owner.Id);
            var circleMembers  = new CircleMembers(circle.Id, owner, circle.Members);
            var circleFullSpec = new CircleMembersFullSpecification();

            if (circleFullSpec.IsSatisfiedBy(circleMembers))
            {
                throw new Exception("サークルが規定人数に達しています。");
            }

            var circleInvitation = new CircleInvitation(circle, fromUser, invitedUser);
            circleInvitationRepository.Save(circleInvitation);

            transaction.Complete();
        }
    }
}
