using System;

public class UserGetInfoService: IUserGetInfoService
{
    private readonly IUserRepository userRepository;
    
    public UserGetInfoService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public UserData Handle(UserGetInfoCommand command)
    {
        var user          = userRepository.Find(new UserId(command.Id));
        var userDataModel = user.ModelBuild(new UserDataModelBuilder());

        return new UserData(userDataModel.Id.Value, userDataModel.Name.Value);
    }
}
