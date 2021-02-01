using System;

class Client
{
    private readonly IUserRegisterService userRegisterService;
    private readonly IUserGetInfoService userGetInfoService;
    private readonly IUserUpdateInfoService userUpdateInfoService;
    private readonly IUserDeleteService userDeleteService;

    public Client(
        IUserRegisterService userRegisterService,
        IUserGetInfoService userGetInfoService,
        IUserUpdateInfoService userUpdateInfoService,
        IUserDeleteService userDeleteService
    )
    {
        this.userRegisterService   = userRegisterService;
        this.userGetInfoService    = userGetInfoService;
        this.userUpdateInfoService = userUpdateInfoService;
        this.userDeleteService     = userDeleteService;
    }

    public void CreateUser(string userName)
    {
        var command = new UserRegisterCommand(userName) { MailAddress = "xxx@xxx.com" };
        userRegisterService.Handle(command);
    }

    public UserData GetUser(string userId)
    {
        var command = new UserGetInfoCommand(userId);
        return userGetInfoService.Handle(command);
    }

    public void UpdateUserName(string userId)
    {
        var command = new UserUpdateInfoCommand(userId) { Name = "fuga" };
        userUpdateInfoService.Handle(command);
    }

    public void UpdateUserMailAddress(string userId)
    {
        var command = new UserUpdateInfoCommand(userId) { MailAddress = "xxx@xxx.com" };
        userUpdateInfoService.Handle(command);
    }

    public void DeleteUser(string userId)
    {
        var command = new UserUpdateInfoCommand(userId) { MailAddress = "xxx@xxx.com" };
        userUpdateInfoService.Handle(command);
    }
}
