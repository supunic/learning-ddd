public class MockUserRegisterService: IUserRegisterService
{
    private readonly IUserRepository userRepository;
    private readonly UserService userService;
    
    public MockUserRegisterService(IUserRepository userRepository, UserService userService)
    {
        this.userRepository = userRepository;
        this.userService = userService;
    }
    
    public void Handle(UserRegisterCommand command)
    {
        // mockデータや例外発生でテスト可能
    }
}
