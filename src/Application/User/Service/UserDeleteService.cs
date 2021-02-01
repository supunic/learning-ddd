using System;

public class UserDeleteService: IUserDeleteService
{
    private readonly IUserRepository userRepository;
    
    public UserDeleteService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public void Handle(UserDeleteCommand command)
    {
        var user = userRepository.Find(new UserId(command.Id));

        if (user == null)
        {
            throw new Exception("ユーザが存在しません。");
        }

        userRepository.Delete(user);
    }
}
