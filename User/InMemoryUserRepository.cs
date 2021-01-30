using System.Collections.Generic;
using System.Linq;

class InMemoryUserRepository: IUserRepository
{
  //テストケースによってはデータを確認したいことがある
  //確認のための操作を外部から行えるようにするためpublicにしている
  
  public Dictionary<UserId, User> Store { get; } = new Dictionary<UserId, User>();

  public void Find(UserName userName)
  {
    var target = Store.Values.FirstOrDefault(user => userName.Equals(user.name));
    
    // if (target != null)
    // {
    //   //インスタンスを直接返さずディープコピーを行う
    //   return Clone(target);
    // }
    // else
    // {
    //   return null;
    // }
  }
  
  public void Save(User user)
  {
    //保存時もディープコピーを行う
    Store[user.id] = Clone(user);
  }
  
  //ディープコピーを行うメソッド
  private User Clone(User user)
  {
    return new User(user.id, user.name);
  }
}
