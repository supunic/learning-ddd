public class CircleInviteCommand
{
    public CircleInviteCommand(string userId, string circleId)
    {
        FromUserId = FromUserId;
        InvitedUserId = InvitedUserId;
        CircleId = circleId;
    }

    public string FromUserId { get; }
    public string InvitedUserId { get; }
    public string CircleId { get; }
}
