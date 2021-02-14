using System.Collections.Generic;

public class UserGetAllInfoService: IUserGetAllInfoService
{
    private readonly IUserRepository userRepository;
    
    public UserGetAllInfoService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public List<UserData> Handle()
    {
        var users             = userRepository.FindAll();
        var userDataModelList = new List<UserData>();

        foreach (User user in users)
        {
            var userDataModel = user.ModelBuild(new UserDataModelBuilder());
            userDataModelList.Add(
                new UserData(userDataModel.Id.Value, userDataModel.Name.Value)
            );
        }

        return userDataModelList;
    }
}
