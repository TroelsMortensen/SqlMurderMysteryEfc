namespace SqlMurderMystery.Entities;

public class FacebookEventCheckin
{
    public int PersonId { get; set; }

    public int EventId { get; set; }

    public string? EventName { get; set; }

    public int Date { get; set; }

    public Person Person { get; set; }
}
