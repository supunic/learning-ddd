using System.Collections.Generic;

public interface IUserRepository
{
    User Find(UserId id);
    User Find(UserName name);
    List<User> Find(List<UserId> members);
    void Save(User user);
    void Delete(User user);
}