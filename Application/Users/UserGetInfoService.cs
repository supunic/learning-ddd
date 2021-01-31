using System;

public class UserGetInfoService
{
    private readonly IUserRepository userRepository;
    
    public UserGetInfoService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public UserData Handle(string userId)
    {
        var targetId = new UserId(userId);
        var user = userRepository.Find(targetId);

        var userData = new UserData(user.Id.Value, user.Name.Value);
        
        return userData;
    }
}
