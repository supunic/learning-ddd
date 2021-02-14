using System.Collections.Generic;
using System.Linq;

class InMemoryUserRepository: IUserRepository
{
    //テストケースによってはデータを確認したいことがある
    //確認のための操作を外部から行えるようにするためpublicにしている

    public Dictionary<UserId, User> Store { get; } = new Dictionary<UserId, User>();

    public User Find(UserName userName)
    {
        var target = Store.Values.FirstOrDefault(
            user => userName.Equals(
                user.ModelBuild(new UserDataModelBuilder()).Name
            )
        );
        
        if (target != null)
        {
            //インスタンスを直接返さずディープコピーを行う
            return Clone(target);
        }
        else
        {
            return null;
        }
    }

    public User Find(UserId userId)
    {
        var target = Store.Values.FirstOrDefault(
            user => userId.Equals(
                user.ModelBuild(new UserDataModelBuilder()).Id
            )
        );
        
        if (target != null)
        {
            //インスタンスを直接返さずディープコピーを行う
            return Clone(target);
        }
        else
        {
            return null;
        }
    }

    public List<User> Find(List<UserId> members)
    {
        // 本来は別処理
        return new List<User>();
    }

    public void Delete(User user)
    {
        //
    }

    public void Save(User user)
    {
        var userDataModel = user.ModelBuild(new UserDataModelBuilder());

        //保存時もディープコピーを行う
        Store[userDataModel.Id] = Clone(user);
    }
    
    //ディープコピーを行うメソッド
    private User Clone(User user)
    {
        var userDataModel = user.ModelBuild(new UserDataModelBuilder());

        return new User(userDataModel.Id, userDataModel.Name);
    }
}
