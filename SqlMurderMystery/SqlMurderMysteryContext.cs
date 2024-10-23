using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SqlMurderMystery.Entities;

namespace SqlMurderMystery;

public class SqlMurderMysteryContext : DbContext
{


    public DbSet<CrimeSceneReport> CrimeSceneReports => Set<CrimeSceneReport>();
    //
    // public DbSet<DriversLicense> DriversLicenses => Set<DriversLicense>();
    //
    // public DbSet<FacebookEventCheckin> FacebookEventCheckins => Set<FacebookEventCheckin>();
    //
    // public DbSet<GetFitNowCheckIn> GetFitNowCheckIns => Set<GetFitNowCheckIn>();
    //
    // public DbSet<GetFitNowMember> GetFitNowMembers => Set<GetFitNowMember>();
    //
    // public DbSet<Income> Incomes => Set<Income>();
    //
    // public DbSet<Interview> Interviews => Set<Interview>();
    //
    // public DbSet<Person> People => Set<Person>();


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source = C:\TRMO\RiderProjects\SqlMurderMystery\SqlMurderMystery\database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(builder =>
        {
            // builder.HasOne<DriversLicense>(person => person.License)
                // .WithOne(license => license.Person)
                
        });

        modelBuilder.Entity<DriversLicense>(builder =>
        {
            builder.HasOne<Person>(license => license.Person)
                .WithOne(person => person.License);

        });
    }
}