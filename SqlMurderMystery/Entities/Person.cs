﻿namespace SqlMurderMystery.Entities;

public class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? LicenseId { get; set; }

    public int AddressNumber { get; set; }

    public string AddressStreetName { get; set; }

    public string? Ssn { get; set; }
    
    public DriversLicense? License { get; set; }

    public Income? Income { get; set; }

    public List<Interview> Interviews { get; set; }

    public List<FacebookEventCheckin> FacebookEventCheckins { get; set; }

    public GetFitNowMember? GetFitNowMember { get; set; }    
}
