public class UserRepository: IUserRepository
{
    public void Save(User user)
    {
        // 本来はSQL処理
    }

    public User Find(UserName userName)
    {
        // 本来はSQL処理
        return new User(new UserName("findByUserName"));
    }

    public User Find(UserId userId)
    {
        // 本来はSQL処理
        return new User(new UserName("findByUserId"));
    }

    public void Delete(User user)
    {
        // 本来はSQL処理
    }
}
