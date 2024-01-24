using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestDrivenHotel.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelRooms",
                columns: table => new
                {
                    RoomNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfBeds = table.Column<int>(type: "int", nullable: false),
                    PricePerNight = table.Column<int>(type: "int", nullable: false),
                    IsBooked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRooms", x => x.RoomNumber);
                });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "RoomNumber", "IsBooked", "NumberOfBeds", "PricePerNight" },
                values: new object[,]
                {
                    { 1, false, 1, 1000 },
                    { 2, false, 2, 2000 },
                    { 3, false, 3, 3000 },
                    { 4, false, 4, 4000 },
                    { 5, false, 5, 5000 },
                    { 6, false, 6, 6000 },
                    { 7, false, 7, 7000 },
                    { 8, false, 8, 8000 },
                    { 9, false, 9, 9000 },
                    { 10, false, 10, 10000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelRooms");
        }
    }
}
