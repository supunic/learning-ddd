public class UserService
{
    private IUserRepository userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public bool Exists(User user)
    {
        var userDataModel  = user.ModelBuild(new UserDataModelBuilder());
        var duplicatedUser = userRepository.Find(userDataModel.Name);

        return duplicatedUser != null;
    }
}
