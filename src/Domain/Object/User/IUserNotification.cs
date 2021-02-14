public interface IUserNotification
{
    void Id(UserId id);
    void Name(UserName name);
    UserDataModel Build();
}