public interface IUserRepository
{
    void Save(User user);
    void Find(UserName name);
}