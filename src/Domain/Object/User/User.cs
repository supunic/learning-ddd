using System;

public class User
{
    public User(UserId id, UserName name)
    {
        if (id == null) throw new ArgumentNullException(nameof(id));
        if (name == null) throw new ArgumentNullException(nameof(name));

        Id = id;
        Name = name;
    }

    private readonly UserId Id;
    private UserName Name;
    private UserMailAddress MailAddress;

    public void ChangeName(UserName name)
    {
        if (name == null) throw new ArgumentNullException(nameof(name));

        Name = name;
    }

    public void ChangeMailAddress(UserMailAddress mailAddress)
    {
        if (mailAddress == null) throw new ArgumentNullException(nameof(mailAddress));

        MailAddress = mailAddress;
    }

    // 以下はUserドメインの振る舞いとは異なるが、Userクラスの内部情報を隠蔽するために作成
    public UserDataModel ModelBuild(IUserNotification userDataModelBuilder) // UserDataModelをbuildして返す
    {
        Notify(userDataModelBuilder); // userDataModelBuilderにuserのidとnameが入る

        return userDataModelBuilder.Build();
    }

    private void Notify(IUserNotification note) // IdとNameがUser内部からしかアクセスできないためここで通知
    {
        note.Id(Id);
        note.Name(Name);
    }
}
