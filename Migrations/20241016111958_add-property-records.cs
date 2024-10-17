using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealStats.Migrations
{
    /// <inheritdoc />
    public partial class addpropertyrecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Properities",
                columns: new[] { "Id", "Area", "Bathrooms", "Bedrooms", "City", "Country", "Description", "Garages", "ManagerId", "Name", "Price", "Street" },
                values: new object[,]
                {
                    { 1, 3000, 3L, 4L, "Los Angeles", "USA", "A beautiful luxury villa with ocean views.", 2L, 1, "Luxury Villa", 1500000.0, "123 Sunset Blvd" },
                    { 2, 1200, 2L, 2L, "Paris", "France", "A stylish apartment in the heart of Paris.", 1L, 1, "Modern Apartment", 750000.0, "45 Rue de Rivoli" },
                    { 3, 800, 1L, 2L, "London", "UK", "A cozy cottage perfect for a small family.", 0L, 1, "Cozy Cottage", 400000.0, "10 Downing St" },
                    { 4, 1500, 1L, 1L, "New York", "USA", "A spacious loft in downtown New York.", 0L, 1, "Spacious Loft", 950000.0, "250 W 34th St" },
                    { 5, 3500, 4L, 5L, "Sydney", "Australia", "A stunning beach house with direct access to the beach.", 3L, 1, "Beach House", 2000000.0, "5 Beach Rd" },
                    { 6, 5000, 5L, 6L, "Toronto", "Canada", "A beautiful farm with plenty of land.", 2L, 1, "Country Farm", 1200000.0, "100 Country Rd" },
                    { 7, 3000, 3L, 3L, "Miami", "USA", "A luxurious penthouse suite with ocean views.", 2L, 1, "Penthouse Suite", 2500000.0, "1 Ocean Dr" },
                    { 8, 2500, 2L, 4L, "Berlin", "Germany", "A family home located in a quiet neighborhood.", 1L, 1, "Family Home", 600000.0, "20 Hauptstrasse" },
                    { 9, 1800, 1L, 2L, "Barcelona", "Spain", "A trendy loft apartment in the city center.", 0L, 1, "Loft Apartment", 850000.0, "15 Passeig de Gràcia" },
                    { 10, 2200, 2L, 3L, "Rome", "Italy", "A modern home with all the latest amenities.", 1L, 1, "Modern Home", 950000.0, "50 Via Roma" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
