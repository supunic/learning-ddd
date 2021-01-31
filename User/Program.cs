using System;

class Program
{
    private readonly UserApplicationService userApplicationService;

    public Program(UserApplicationService userApplicationService)
    {
        this.userApplicationService = userApplicationService;
    }

    public void CreateUser(string userName)
    {
        userApplicationService.Register(userName);
    }

    public void UpdateUserName(string userId)
    {
        var updateNameCommand = new UserUpdateCommand(userId)
        {
            Name = "fuga",
        };
        userApplicationService.Update(updateNameCommand);
    }

    public void UpdateUserMailAddress(string userId)
    {
        var updateMailAddressCommand = new UserUpdateCommand(userId)
        {
            MailAddress = "xxx@xxx.com",
        };
        userApplicationService.Update(updateMailAddressCommand);
    }
}
