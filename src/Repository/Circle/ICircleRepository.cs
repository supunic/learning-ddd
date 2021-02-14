using System;
using System.Collections.Generic;

public interface ICircleRepository
{
    void Save(Circle circle);
    Circle Find(CircleId id);
    Circle Find(CircleName name);
    List<Circle> FindAll();
    List<Circle> FindRecommended(DateTime now);
}