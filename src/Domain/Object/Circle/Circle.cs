using System;
using System.Collections.Generic;

public class Circle
{
    public Circle(CircleId id, CircleName name, User owner, List<UserId> members)
    {
        if (id == null) throw new ArgumentNullException(nameof(id));
        if (name == null) throw new ArgumentNullException(nameof(name));
        if (owner == null) throw new ArgumentNullException(nameof(owner));
        if (members == null) throw new ArgumentNullException(nameof(members));

        Id = id;
        Name = name;
        Owner = owner;
        Members = members;
    }

    public CircleId Id { get; }
    public CircleName Name { get; private set; }
    public User Owner { get; private set; }
    public List<UserId> Members;

    public bool IsFull()
    {
        return MembersCount() >= 29;
    }

    public int MembersCount()
    {
        return Members.Count + 1;
    }

    public void Join(User user)
    {
        if (user == null) throw new ArgumentNullException(nameof(user));

        if (IsFull())
        {
            throw new Exception("サークルが規定人数に達しています。");
        }

        Members.Add(user.Id);
    }
}
