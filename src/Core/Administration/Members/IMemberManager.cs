namespace LinkUp.Administration.Members;

public interface IMemberManager
{
    Task<Guid> Create(CreateMemberCommand command);

    Task<Member> Find(MemberQuery query);
}