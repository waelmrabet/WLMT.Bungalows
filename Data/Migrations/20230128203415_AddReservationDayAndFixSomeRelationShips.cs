using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddReservationDayAndFixSomeRelationShips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Convenience_Bungalows_BungalowId",
                table: "Convenience");

            migrationBuilder.DropIndex(
                name: "IX_Convenience_BungalowId",
                table: "Convenience");

            migrationBuilder.DropColumn(
                name: "BungalowId",
                table: "Convenience");

            migrationBuilder.CreateTable(
                name: "BungalowConvenience",
                columns: table => new
                {
                    BungalowsId = table.Column<int>(type: "int", nullable: false),
                    ConveniencesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BungalowConvenience", x => new { x.BungalowsId, x.ConveniencesId });
                    table.ForeignKey(
                        name: "FK_BungalowConvenience_Bungalows_BungalowsId",
                        column: x => x.BungalowsId,
                        principalTable: "Bungalows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BungalowConvenience_Convenience_ConveniencesId",
                        column: x => x.ConveniencesId,
                        principalTable: "Convenience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResevationDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationTenantInfoId = table.Column<int>(type: "int", nullable: true),
                    ReservationBungalowId = table.Column<int>(type: "int", nullable: true),
                    ReservationStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReservationEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResevationDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResevationDay_Reservations_ReservationTenantInfoId_ReservationBungalowId_ReservationStartDate_ReservationEndDate",
                        columns: x => new { x.ReservationTenantInfoId, x.ReservationBungalowId, x.ReservationStartDate, x.ReservationEndDate },
                        principalTable: "Reservations",
                        principalColumns: new[] { "TenantInfoId", "BungalowId", "StartDate", "EndDate" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BungalowConvenience_ConveniencesId",
                table: "BungalowConvenience",
                column: "ConveniencesId");

            migrationBuilder.CreateIndex(
                name: "IX_ResevationDay_ReservationTenantInfoId_ReservationBungalowId_ReservationStartDate_ReservationEndDate",
                table: "ResevationDay",
                columns: new[] { "ReservationTenantInfoId", "ReservationBungalowId", "ReservationStartDate", "ReservationEndDate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BungalowConvenience");

            migrationBuilder.DropTable(
                name: "ResevationDay");

            migrationBuilder.AddColumn<int>(
                name: "BungalowId",
                table: "Convenience",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Convenience_BungalowId",
                table: "Convenience",
                column: "BungalowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Convenience_Bungalows_BungalowId",
                table: "Convenience",
                column: "BungalowId",
                principalTable: "Bungalows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
