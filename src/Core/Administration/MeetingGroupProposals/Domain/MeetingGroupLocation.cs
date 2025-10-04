namespace LinkUp.Administration.MeetingGroupProposals;

public record MeetingGroupLocation
{
    private MeetingGroupLocation(string city, string countryCode)
    {
        City = city;
        CountryCode = countryCode;
    }

    public string City { get; }

    public string CountryCode { get; }

    public static MeetingGroupLocation Create(string city, string countryCode)
    {
        return new(city, countryCode);
    }
}
