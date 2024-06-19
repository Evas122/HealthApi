using HealthApp.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage
{
    public class HealthAppDbContext : DbContext
    {
        public DbSet<HealthData>? HealthDatas { get; set; }
        public DbSet<HealthReport>? HealthReports { get; set; }
        public DbSet<MonitoringDevice>? MonitoringDevices { get; set; }
        public DbSet<User>? Users { get; set; }

        public HealthAppDbContext() { }

        public HealthAppDbContext(DbContextOptions<HealthAppDbContext> options) : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=HealthAppDatabase;Username=postgres;Password=admin");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
