using System;

public interface IUserRegisterService
{
    void Handle(UserRegisterCommand command);
}
