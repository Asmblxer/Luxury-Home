using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealStats.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeFeatureAndAddTableImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Properities_ProperityId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_ProperityId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ProperityId",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Properities",
                newName: "Street");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Properities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FeatureProperity",
                columns: table => new
                {
                    FeaturesId = table.Column<int>(type: "int", nullable: false),
                    ProperitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureProperity", x => new { x.FeaturesId, x.ProperitiesId });
                    table.ForeignKey(
                        name: "FK_FeatureProperity_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureProperity_Properities_ProperitiesId",
                        column: x => x.ProperitiesId,
                        principalTable: "Properities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProperityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Properities_ProperityId",
                        column: x => x.ProperityId,
                        principalTable: "Properities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Swimming Pool" },
                    { 2, "Laundry Room" },
                    { 3, "Emergency Exit" },
                    { 4, "Fire Place" },
                    { 5, "Garden" },
                    { 6, "Smart Home" },
                    { 7, "Elevator Access" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureProperity_ProperitiesId",
                table: "FeatureProperity",
                column: "ProperitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProperityId",
                table: "Image",
                column: "ProperityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureProperity");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Properities");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Properities",
                newName: "Address");

            migrationBuilder.AddColumn<int>(
                name: "ProperityId",
                table: "Features",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Features_ProperityId",
                table: "Features",
                column: "ProperityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Properities_ProperityId",
                table: "Features",
                column: "ProperityId",
                principalTable: "Properities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
