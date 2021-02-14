using System;

public class CircleRecommendSpecification: ISpecification<Circle>
{
    private readonly DateTime executeDateTime;

    public CircleRecommendSpecification(DateTime executeDateTime)
    {
        this.executeDateTime = executeDateTime;
    }

    public bool IsSatisfiedBy(Circle circle)
    {
        if (circle.Members.CountMembers() < 0)
        {
            return false;
        }

        return circle.Created > executeDateTime.AddMonths(-1);
    }
}
