﻿using System;

public class Circle
{
    public Circle(CircleId id, CircleName name, User owner, CircleMembers members)
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
    public CircleMembers Members;
    public DateTime Created;

    public void Join(User user)
    {
        if (user == null) throw new ArgumentNullException(nameof(user));

        Members.Add(user);
    }
}
