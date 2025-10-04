namespace LinkUp.Administration.Members.Tests;

public class MemberTest
{
    [Fact]
    public void Constructor()
    {
        var member = new Member(Guid.Parse("11111111-2222-3333-4444-555555555555"), "John Login", "jhon.doe@domain.com", "John", "Doe", "John Doe");

        Assert.Equal(Guid.Parse("11111111-2222-3333-4444-555555555555"), member.Id);
        Assert.Equal("John Login", member.Login);
        Assert.Equal("jhon.doe@domain.com", member.Email);
        Assert.Equal("John", member.FirstName);
        Assert.Equal("Doe", member.LastName);
        Assert.Equal("John Doe", member.Name);
    }
}
