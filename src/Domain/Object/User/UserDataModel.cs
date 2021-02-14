// ORMなどに渡すときにUserのインスタンス変数がprivateの場合使用する
// DTOで定義したUserDataと目的は異なるが、実態は一緒なので使いまわせそう

public class UserDataModel
{
    public UserDataModel()
    {
        //
    }

    public UserId Id { get; set; }
    public UserName Name { get; set; }
    public UserMailAddress MailAddress { get; set; }
}