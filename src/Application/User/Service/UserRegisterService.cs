using System;

public class UserRegisterService: IUserRegisterService
{
    private readonly IUserFactory userFactory;
    private readonly IUserRepository userRepository;
    private readonly UserService userService;
    
    public UserRegisterService(IUserRepository userRepository, UserService userService)
    {
        this.userRepository = userRepository;
        this.userService = userService;
    }
    
    public void Handle(UserRegisterCommand command)
    {
        var user = userFactory.Create(new UserName(command.Name));

        if (userService.Exists(user))
        {
            throw new Exception("ユーザは既に存在しています。");
        }

        userRepository.Save(user);
    }
}
