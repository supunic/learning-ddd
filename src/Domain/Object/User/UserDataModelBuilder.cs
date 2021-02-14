public class UserDataModelBuilder: IUserNotification
{
    private UserId id;
    private UserName name;

    public void Id(UserId id)
    {
        this.id = id;
    }

    public void Name(UserName name)
    {
        this.name = name;
    }

    public UserDataModel Build()
    {
        return new UserDataModel
        {
            Id = id,
            Name = name
        };
    }
}
