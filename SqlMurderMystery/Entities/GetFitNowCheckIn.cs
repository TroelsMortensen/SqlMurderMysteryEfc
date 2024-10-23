namespace SqlMurderMystery.Entities;

public class GetFitNowCheckIn
{
    public int Id { get; set; }
    
    public string MembershipId { get; set; }

    public int CheckInDate { get; set; }

    public int CheckInTime { get; set; }

    public int CheckOutTime { get; set; }

    public GetFitNowMember Membership { get; set; }
}
