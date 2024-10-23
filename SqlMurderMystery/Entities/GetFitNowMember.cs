namespace SqlMurderMystery.Entities;

public partial class GetFitNowMember
{
    public string Id { get; set; } = null!;

    public int? PersonId { get; set; }

    public string? Name { get; set; }

    public int? MembershipStartDate { get; set; }

    public string? MembershipStatus { get; set; }

    public virtual Person? Person { get; set; }
}
