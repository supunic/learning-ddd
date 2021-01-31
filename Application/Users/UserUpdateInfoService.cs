using System;

public class UserUpdateInfoService
{
    private readonly IUserRepository userRepository;
    private readonly UserService userService;
    
    public UserUpdateInfoService(IUserRepository userRepository, UserService userService)
    {
        this.userRepository = userRepository;
        this.userService = userService;
    }

    public void Handle(UserUpdateCommand command)
    {
        var targetId = new UserId(command.Id);
        var user = userRepository.Find(targetId);
        if (user == null)
        {
            throw new Exception("ユーザが存在しません。");
        }

        var name = command.Name;
        if (name != null)
        {
            var newUserName = new UserName(name);
            user.ChangeName(newUserName);

            if (userService.Exists(user))
            {
                throw new Exception("ユーザは既に存在しています。");
            }
        }

        var mailAddress = command.MailAddress;
        if (mailAddress != null)
        {
            var newUserMailAddress = new UserMailAddress(mailAddress);
            user.ChangeMailAddress(newUserMailAddress);
        }

        userRepository.Save(user);
    }
}
