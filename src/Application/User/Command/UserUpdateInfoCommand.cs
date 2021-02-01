public class UserUpdateInfoCommand
{
    public UserUpdateInfoCommand(string id)
    {
        Id = id;
    }

    public string Id { get; }
    public string Name { get; set; }
    public string MailAddress { get; set; }
}
