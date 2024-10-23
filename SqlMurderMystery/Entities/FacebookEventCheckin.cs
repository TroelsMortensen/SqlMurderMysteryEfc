namespace SqlMurderMystery.Entities;

public partial class FacebookEventCheckin
{
    public int? PersonId { get; set; }

    public int? EventId { get; set; }

    public string? EventName { get; set; }

    public int? Date { get; set; }

    public virtual Person? Person { get; set; }
}
