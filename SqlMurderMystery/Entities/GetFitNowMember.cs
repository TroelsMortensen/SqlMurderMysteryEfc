namespace SqlMurderMystery.Entities;

public class GetFitNowMember
{
    public string Id { get; set; } = null!;

    public int PersonId { get; set; }

    public string Name { get; set; }

    public int MembershipStartDate { get; set; }

    public string MembershipStatus { get; set; }

    public Person Person { get; set; }

    public List<GetFitNowCheckIn> CheckIns { get; set; }
}
