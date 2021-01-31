public class UserService
{
    private IUserRepository userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public bool Exists(User user)
    {
        var duplicatedUser = userRepository.Find(user.Name);

        return duplicatedUser != null;
    }
}
