namespace SqlMurderMystery.Entities;

public class CrimeSceneReport
{
    public int Id { get; set; }
    
    public int Date { get; set; }

    public string Type { get; set; }

    public string? Description { get; set; }

    public string City { get; set; }
}
