public class UserFactory: IUserFactory
{
    public User Create(UserName name)
    {
        // User作成処理
        // ...
        var id = new UserId("xxx"); // 本当はDB処理後のID
        return new User(id, name);
    }
}