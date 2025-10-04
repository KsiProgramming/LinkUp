namespace LinkUp.Administration.Members;

public interface IMemberRepository
{
    Task<Guid> AddAsync(Member member);

    Task<Member> GetByIdAsync(Guid Id);
}