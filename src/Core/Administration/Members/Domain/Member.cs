namespace LinkUp.Administration.Members;
public class Member
{
    public Member(Guid id, string login, string email, string firstName, string lastName, string name)
    {
        Id = id;
        Login = login;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Name = name;
    }

    public Guid Id { get; }

    public string Login { get; }

    public string Email { get; }

    public string FirstName { get; }

    public string LastName { get; }

    public string Name { get; }
}