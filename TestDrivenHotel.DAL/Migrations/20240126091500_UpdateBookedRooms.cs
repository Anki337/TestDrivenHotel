using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDrivenHotel.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookedRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestId);
                });

            migrationBuilder.CreateTable(
                name: "BookedRooms",
                columns: table => new
                {
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedRooms", x => new { x.RoomNumber, x.GuestId });
                    table.ForeignKey(
                        name: "FK_BookedRooms_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedRooms_HotelRooms_RoomNumber",
                        column: x => x.RoomNumber,
                        principalTable: "HotelRooms",
                        principalColumn: "RoomNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookedRooms_GuestId",
                table: "BookedRooms",
                column: "GuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookedRooms");

            migrationBuilder.DropTable(
                name: "Guests");
        }
    }
}
