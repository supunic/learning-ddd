public class User
{
    public readonly UserId id;
    public UserName name;

    public User(UserId id, UserName name)
    {
        this.id = id;
        ChangeUserName(name);
    }

    public void ChangeUserName(UserName name)
    {
        this.name = name;
    }

    public bool Equals(User other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Equals(id, other.id); // 比較はid同士で行う
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((User) obj);
    }

    public override int GetHashCode()
    {
        return (id != null ? id.GetHashCode() : 0);
    }
}
