

using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data;

public class APIdbContext : DbContext
{
    public DbSet<FlightObject> Flights => Set<FlightObject>();
    public DbSet<PassengerObject> Passengers => Set<PassengerObject>();

    public APIdbContext(DbContextOptions options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new FlightConfiguration());
        modelBuilder.ApplyConfiguration(new PassengerConfiguration());
    }
}