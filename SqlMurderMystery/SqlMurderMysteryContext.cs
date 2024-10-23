using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel.Resolution;
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
            builder.HasIndex(p => p.LicenseId).IsUnique();
            builder.HasIndex(p => p.Ssn).IsUnique();

            builder.HasOne<Income>(person => person.Income)
                .WithOne(income => income.Person)
                .HasForeignKey<Income>(income => income.Ssn)
                .HasPrincipalKey<Person>(person => person.Ssn);
        });

        modelBuilder.Entity<DriversLicense>(builder =>
        {
            builder.HasOne<Person>(license => license.Person)
                .WithOne(person => person.License)
                .HasForeignKey<DriversLicense>(license => license.PersonId)
                .HasPrincipalKey<Person>(person => person.Id);
        });

        modelBuilder.Entity<Income>(builder =>
        {
            builder.HasKey(i => i.Ssn);
            
        });
    }
}