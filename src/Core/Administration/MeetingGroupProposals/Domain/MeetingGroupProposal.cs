namespace LinkUp.Administration.MeetingGroupProposals;

public class MeetingGroupProposal
{
    public string Name { get; }

    public string Description { get; }

    public MeetingGroupLocation Location { get; }

    public DateTime ProposalDate { get; }

    public Guid ProposalUserId { get; }

    public MeetingGroupProposalStatus Status { get; private set; }

    public MeetingGroupProposalDecision Decision { get; private set; }

    public MeetingGroupProposal(Guid id, string name, string description, MeetingGroupLocation location, Guid proposalUserId, DateTime proposalDate)
    {
        Name = name;
        Description = description;
        Location = location;
        ProposalDate = proposalDate;
        ProposalUserId = proposalUserId;
        Status = MeetingGroupProposalStatus.ToVerify;
        Decision = MeetingGroupProposalDecision.NoDecision;
        Id = id;
    }

    private MeetingGroupProposal()
    {
        Decision = MeetingGroupProposalDecision.NoDecision;
    }

    public Guid Id { get; }

    public void Accept(Guid userId)
    {
        Decision = MeetingGroupProposalDecision.AcceptDecision(DateTime.UtcNow, userId);

        Status = Decision.GetStatusForDecision();
    }

    public void Reject(Guid userId, string rejectReason)
    {
        Decision = MeetingGroupProposalDecision.RejectDecision(DateTime.UtcNow, userId, rejectReason);

        Status = Decision.GetStatusForDecision();
    }

    public static MeetingGroupProposal CreateToVerify(
        Guid id,
        string name,
        string description,
        MeetingGroupLocation location,
        Guid proposalUserId,
        DateTime proposalDate)
    {
        return new(id, name, description, location, proposalUserId, proposalDate);
    }
}