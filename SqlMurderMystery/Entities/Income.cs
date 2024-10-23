namespace SqlMurderMystery.Entities;

public class Income
{
    public string Ssn { get; set; }

    public int AnnualIncome { get; set; }

    public Person Person { get; set; }
}
