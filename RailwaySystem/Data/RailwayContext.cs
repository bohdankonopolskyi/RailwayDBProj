using System;
using Microsoft.EntityFrameworkCore;
using RailwaySystem.Models;
namespace RailwaySystem.Data
{
    public class RailwayContext : DbContext
    {
        public RailwayContext(DbContextOptions<RailwayContext> options) : base(options)
        {
        }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<WagonSeatPrice> WagonSeatPrices { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<StationInRoute> StationInRoutes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wagon> Wagons { get; set; }
    }
}
