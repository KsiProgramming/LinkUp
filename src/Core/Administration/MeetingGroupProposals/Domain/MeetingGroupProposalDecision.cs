namespace LinkUp.Administration.MeetingGroupProposals;

public record MeetingGroupProposalDecision
{
    private MeetingGroupProposalDecision(DateTime? date, Guid userId, string code, string rejectReason)
    {
        this.Date = date;
        this.UserId = userId;
        this.Code = code;
        this.RejectReason = rejectReason;
    }

    public DateTime? Date { get; }

    public Guid UserId { get; }

    public string Code { get; }

    public string RejectReason { get; }

    internal static MeetingGroupProposalDecision NoDecision => new(null, Guid.Empty, null, null);

    public static MeetingGroupProposalDecision AcceptDecision(DateTime date, Guid userId)
    {
        return new(date, userId, "Accept", null);
    }

    public static MeetingGroupProposalDecision RejectDecision(DateTime date, Guid userId, string rejectReason)
    {
        return new(date, userId, "Reject", rejectReason);
    }

    public MeetingGroupProposalStatus GetStatusForDecision()
    {
        return this.Code switch
        {
            "Accept" => MeetingGroupProposalStatus.Verified,
            "Reject" => MeetingGroupProposalStatus.Create("Rejected"),
            _ => MeetingGroupProposalStatus.ToVerify
        };
    }
}
