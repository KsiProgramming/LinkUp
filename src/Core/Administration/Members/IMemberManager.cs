namespace LinkUp.Administration.Members;

public interface IMemberManager
{
    void Create(CreateMemberCommand command);

    void Find(MemberQuery query);
}