namespace SqlMurderMystery.Entities;

public class DriversLicense
{
    public int Id { get; set; }

    public int Age { get; set; }

    public int Height { get; set; }

    public string EyeColor { get; set; }

    public string HairColor { get; set; }

    public string Gender { get; set; }

    public string PlateNumber { get; set; }

    public string CarMake { get; set; }

    public string CarModel { get; set; }

    public Person Person { get; set; }
}
