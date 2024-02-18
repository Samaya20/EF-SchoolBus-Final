using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolBusData_Models.Derived;

namespace SchoolBusData.Contexts;

public class MainContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var ConStr = new ConfigurationManager()
    .AddJsonFile("Settings\\appconfig.json")
    .Build()
    .GetConnectionString("DefaultConnection");


        optionsBuilder.UseSqlServer(ConStr);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
