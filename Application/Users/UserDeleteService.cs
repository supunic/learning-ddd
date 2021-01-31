using System;

public class UserDeleteService
{
    private readonly IUserRepository userRepository;
    
    public UserDeleteService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public void Delete(UserDeleteCommand command)
    {
        var targetId = new UserId(command.Id);
        var user = userRepository.Find(targetId);

        if (user == null)
        {
            throw new Exception("ユーザが存在しません。");
        }

        userRepository.Delete(user);
    }
}
