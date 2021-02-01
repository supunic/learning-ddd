public class UserDeleteCommand
{
    public UserDeleteCommand(string id)
    {
        Id = id;
    }

    public string Id { get; }
    public string Name { get; set; }
}
