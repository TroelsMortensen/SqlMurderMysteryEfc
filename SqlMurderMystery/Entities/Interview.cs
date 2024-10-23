namespace SqlMurderMystery.Entities;

public class Interview
{
    public int Id { get; set; }
    
    public int PersonId { get; set; }

    public string Transcript { get; set; }

    public Person Person { get; set; }
}
