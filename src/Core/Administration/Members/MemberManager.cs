namespace LinkUp.Administration.Members;

public class MemberManager : IMemberManager
{
    public void Create(CreateMemberCommand command)
    {
        Console.WriteLine($"Creating member: {command.Name} with ID: {command.MemberId}");
    }

    public void Find(MemberQuery query)
    {
        Console.WriteLine($"Retrieving member with ID: {query.MemberId}");
    }
}
