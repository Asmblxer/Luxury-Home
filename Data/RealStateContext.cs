using Microsoft.EntityFrameworkCore;
using RealStats.Models;

namespace RealStats.Data
{
    public class RealStateContext:DbContext
    {
        public RealStateContext(DbContextOptions<RealStateContext> options) : base(options)
        {

        }
        public DbSet<Manager> Managers {  get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<Properity> Properities { get; set; }
        public DbSet<LeaseAgreement> LeaseAgreement { get; set; }   
        public DbSet<ReportIssue> ReportIssues { get; set; }
        public DbSet<Payment> Payment { get; set; } 
        public DbSet<ProperityStatus> ProperityStatus { get; set; }
        public DbSet<Feature> Features { get; set; }    
    }
}
