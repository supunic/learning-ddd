public class CircleService
{
    private ICircleRepository circleRepository;
    
    public CircleService(ICircleRepository circleRepository)
    {
        this.circleRepository = circleRepository;
    }

    public bool Exists(Circle circle)
    {
        var duplicatedCircle = circleRepository.Find(circle.Name);

        return duplicatedCircle != null;
    }
}
