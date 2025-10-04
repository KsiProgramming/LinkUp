namespace LinkUp.Administration.Members;

public class MemberManager : IMemberManager
{
    private readonly IMemberRepository repository;

    public MemberManager(IMemberRepository repository) { this.repository = repository; }

    public async Task<Guid> Create(CreateMemberCommand command)
    {
        var memeberToAdd = new Member(command.MemberId, command.Login, command.Email, command.FirstName, command.LastName, command.Name);
        await this.repository.AddAsync(memeberToAdd);

        return memeberToAdd.Id;
    }

    public async Task<Member> Find(MemberQuery query)
    {
        return await this.repository.GetByIdAsync(query.Id!.Value);
    }
}
