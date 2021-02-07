public class UserRepository: IUserRepository
{
    public void Save(User user)
    {
        // 本来はSQL処理
    }

    public User Find(UserName userName)
    {
        // 本来はSQL処理
        return new User(new UserId("findByUserName"), userName);
    }

    public User Find(UserId userId)
    {
        // 本来はSQL処理
        return new User(userId, new UserName("findByUserId"));
    }

    public void Delete(User user)
    {
        // 本来はSQL処理
    }
}
