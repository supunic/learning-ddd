public interface ICircleRepository
{
    void Save(Circle user);
    Circle Find(CircleId id);
    Circle Find(CircleName name);
}