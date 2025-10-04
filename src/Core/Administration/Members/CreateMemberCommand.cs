
namespace LinkUp.Administration.Members;

public class CreateMemberCommand
{
    public CreateMemberCommand(
            Guid memberId,
            string login,
            string email,
            string firstName,
            string lastName,
            string name)
    {
        Login = login;
        MemberId = memberId;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Name = name;
    }

    public Guid MemberId { get; }

    public string Login { get; }

    public string Email { get; }

    public string FirstName { get; }

    public string LastName { get; }

    public string Name { get; }
}