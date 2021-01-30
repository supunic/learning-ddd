public class UserService
{
    private IUserRepository userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }
    public bool Exists(User user)
    {
        userRepository.Find(user.name);
        return false;
    }
}
