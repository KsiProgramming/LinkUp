namespace LinkUp.Administration.MeetingGroupProposals;

public record MeetingGroupProposalStatus
{
    private MeetingGroupProposalStatus(string value)
    {
        Value = value;
    }

    public static MeetingGroupProposalStatus ToVerify => new("ToVerify");

    public static MeetingGroupProposalStatus Verified => new("Verified");

    public string Value { get; }

    public static MeetingGroupProposalStatus Create(string value)
    {
        return new(value);
    }
}
