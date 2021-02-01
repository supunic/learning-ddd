using System;

public class User
{
    public User(UserName name)
    {
        if (name == null) throw new ArgumentNullException(nameof(name));

        Id = new UserId(Guid.NewGuid().ToString());
        Name = name;
    }

    public User(UserId id, UserName name)
    {
        if (id == null) throw new ArgumentNullException(nameof(id));
        if (name == null) throw new ArgumentNullException(nameof(name));

        Id = id;
        Name = name;
    }

    public UserId Id { get; }
    public UserName Name { get; private set; }
    public UserMailAddress MailAddress { get; private set; }

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
}
