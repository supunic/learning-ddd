using System;

public class UserUpdateInfoService: IUserUpdateInfoService
{
    private readonly IUserRepository userRepository;
    private readonly UserService userService;
    
    public UserUpdateInfoService(IUserRepository userRepository, UserService userService)
    {
        this.userRepository = userRepository;
        this.userService = userService;
    }

    public void Handle(UserUpdateInfoCommand command)
    {
        var user = userRepository.Find(new UserId(command.Id));

        if (user == null)
        {
            throw new Exception("ユーザが存在しません。");
        }

        if (command.Name != null)
        {
            user.ChangeName(new UserName(command.Name));

            if (userService.Exists(user))
            {
                throw new Exception("ユーザは既に存在しています。");
            }
        }

        if (command.MailAddress != null)
        {
            user.ChangeMailAddress(new UserMailAddress(command.MailAddress));
        }

        userRepository.Save(user);
    }
}
