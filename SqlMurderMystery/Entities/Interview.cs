namespace SqlMurderMystery.Entities;

public partial class Interview
{
    public int? PersonId { get; set; }

    public string? Transcript { get; set; }

    public virtual Person? Person { get; set; }
}
