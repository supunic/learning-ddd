using System.Collections.Generic;
using System.Linq;

public class CircleMembers: List<User>
{
    private readonly User owner;
    private readonly List<User> members;

    public CircleMembers(CircleId id, User owner, List<User> members)
    {
        Id = id;
        this.members = members;
    }

    public CircleId Id { get; }

    public int CountMembers()
    {
        return members.Count() + 1;
    }

    public int CountPremiumMembers(bool containsOwner = true)
    {
        var premiumUserNumber = members.Count(user => user.IsPremium());

        if (containsOwner)
        {
            return premiumUserNumber + (owner.IsPremium() ? 1 : 0);
        }
        else
        {
            return premiumUserNumber;
        }
    }
}