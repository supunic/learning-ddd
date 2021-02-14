using System.Collections.Generic;

public class UserRepository: IUserRepository
{
    public void Save(User user)
    {
        var userDataModel = user.ModelBuild(new UserDataModelBuilder());

        // 以後、userDataModelをORMに渡す
        // userDataModelBuilderを使うことでUserのidやnameなど内部データも非公開にしたままにできる
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

    public List<User> Find(List<UserId> members)
    {
        // 本来はSQL処理
        var userList = new List<User>();
        foreach (UserId member in members) {
            userList.Add(new User(member, new UserName("findByUserId")));
        }
        return userList;
    }

    public void Delete(User user)
    {
        // 本来はSQL処理
    }
}
