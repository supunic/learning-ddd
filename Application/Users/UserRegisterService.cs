using System;

public class UserRegisterService
{
    private readonly IUserRepository userRepository;
    private readonly UserService userService;
    
    public UserRegisterService(IUserRepository userRepository, UserService userService)
    {
        this.userRepository = userRepository;
        this.userService = userService;
    }
    
    public void Register(string name)
    {
        var user = new User(new UserName(name));

        if (userService.Exists(user))
        {
            throw new Exception("ユーザは既に存在しています。");
        }

        userRepository.Save(user);
    }
}
