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
}
