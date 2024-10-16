using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealStats.Models;

namespace RealStats.Data
{
    public class RealStateContext : IdentityDbContext<ApplicationUser>
    {
        public RealStateContext(DbContextOptions<RealStateContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Feature>().HasData(
                new Feature {Id = 1 ,  Name = "Swimming Pool" },
                new Feature {Id = 2 ,  Name = "Laundry Room"},
                new Feature {Id = 3 ,  Name = "Emergency Exit"},
                new Feature {Id = 4 ,  Name = "Fire Place"},
                new Feature {Id = 5 ,  Name = "Garden"},
                new Feature {Id = 6 ,  Name = "Smart Home"},
                new Feature {Id = 7 ,  Name = "Elevator Access" }
            );
            // Seed Properties
            builder.Entity<Properity>().HasData(
                new Properity
                {
                    Id = 1,
                    Name = "Luxury Villa",
                    Country = "USA",
                    City = "Los Angeles",
                    Street = "123 Sunset Blvd",
                    Area = 3000,
                    Description = "A beautiful luxury villa with ocean views.",
                    Bedrooms = 4,
                    Bathrooms = 3,
                    Garages = 2,
                    Price = 1500000,
                    ManagerId = 1,
                },
                new Properity
                {
                    Id = 2,
                    Name = "Modern Apartment",
                    Country = "France",
                    City = "Paris",
                    Street = "45 Rue de Rivoli",
                    Area = 1200,
                    Description = "A stylish apartment in the heart of Paris.",
                    Bedrooms = 2,
                    Bathrooms = 2,
                    Garages = 1,
                    Price = 750000,
                    ManagerId = 1,
                },
                new Properity
                {
                    Id = 3,
                    Name = "Cozy Cottage",
                    Country = "UK",
                    City = "London",
                    Street = "10 Downing St",
                    Area = 800,
                    Description = "A cozy cottage perfect for a small family.",
                    Bedrooms = 2,
                    Bathrooms = 1,
                    Garages = 0,
                    Price = 400000,
                    ManagerId = 1,
                },
                new Properity
                {
                    Id = 4,
                    Name = "Spacious Loft",
                    Country = "USA",
                    City = "New York",
                    Street = "250 W 34th St",
                    Area = 1500,
                    Description = "A spacious loft in downtown New York.",
                    Bedrooms = 1,
                    Bathrooms = 1,
                    Garages = 0,
                    Price = 950000,
                    ManagerId = 1,
                },
                new Properity
                {
                    Id = 5,
                    Name = "Beach House",
                    Country = "Australia",
                    City = "Sydney",
                    Street = "5 Beach Rd",
                    Area = 3500,
                    Description = "A stunning beach house with direct access to the beach.",
                    Bedrooms = 5,
                    Bathrooms = 4,
                    Garages = 3,
                    Price = 2000000,
                    ManagerId = 1,
                },
                new Properity
                {
                    Id = 6,
                    Name = "Country Farm",
                    Country = "Canada",
                    City = "Toronto",
                    Street = "100 Country Rd",
                    Area = 5000,
                    Description = "A beautiful farm with plenty of land.",
                    Bedrooms = 6,
                    Bathrooms = 5,
                    Garages = 2,
                    Price = 1200000,
                    ManagerId = 1,
                },
                new Properity
                {
                    Id = 7,
                    Name = "Penthouse Suite",
                    Country = "USA",
                    City = "Miami",
                    Street = "1 Ocean Dr",
                    Area = 3000,
                    Description = "A luxurious penthouse suite with ocean views.",
                    Bedrooms = 3,
                    Bathrooms = 3,
                    Garages = 2,
                    Price = 2500000,
                    ManagerId = 1,
                },
                new Properity
                {
                    Id = 8,
                    Name = "Family Home",
                    Country = "Germany",
                    City = "Berlin",
                    Street = "20 Hauptstrasse",
                    Area = 2500,
                    Description = "A family home located in a quiet neighborhood.",
                    Bedrooms = 4,
                    Bathrooms = 2,
                    Garages = 1,
                    Price = 600000,
                    ManagerId = 1,
                },
                new Properity
                {
                    Id = 9,
                    Name = "Loft Apartment",
                    Country = "Spain",
                    City = "Barcelona",
                    Street = "15 Passeig de Gràcia",
                    Area = 1800,
                    Description = "A trendy loft apartment in the city center.",
                    Bedrooms = 2,
                    Bathrooms = 1,
                    Garages = 0,
                    Price = 850000,
                    ManagerId = 1,
                    
                },
                new Properity
                {
                    Id = 10,
                    Name = "Modern Home",
                    Country = "Italy",
                    City = "Rome",
                    Street = "50 Via Roma",
                    Area = 2200,
                    Description = "A modern home with all the latest amenities.",
                    Bedrooms = 3,
                    Bathrooms = 2,
                    Garages = 1,
                    Price = 950000,
                    ManagerId = 1,
                }
        );
  
        }
        
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<Properity> Properities { get; set; }
        public DbSet<LeaseAgreement> LeaseAgreement { get; set; }
        public DbSet<ReportIssue> ReportIssues { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<ProperityStatus> ProperityStatus { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
    
}
