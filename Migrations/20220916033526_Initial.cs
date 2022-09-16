using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD_340_W22SD_Lab_3.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectionId = table.Column<int>(type: "int", nullable: true),
                    RampAccessible = table.Column<bool>(type: "bit", nullable: true),
                    BicycleAccessible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Routes_Directions_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "Directions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stop",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stop", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Stop_Directions_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "Directions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ScheduledStops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StopNumber = table.Column<int>(type: "int", nullable: true),
                    RouteNumber = table.Column<int>(type: "int", nullable: true),
                    ScheduledArrival = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledStops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledStops_Routes_RouteNumber",
                        column: x => x.RouteNumber,
                        principalTable: "Routes",
                        principalColumn: "Number");
                    table.ForeignKey(
                        name: "FK_ScheduledStops_Stop_StopNumber",
                        column: x => x.StopNumber,
                        principalTable: "Stop",
                        principalColumn: "Number");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_DirectionId",
                table: "Routes",
                column: "DirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledStops_RouteNumber",
                table: "ScheduledStops",
                column: "RouteNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledStops_StopNumber",
                table: "ScheduledStops",
                column: "StopNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Stop_DirectionId",
                table: "Stop",
                column: "DirectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduledStops");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Stop");

            migrationBuilder.DropTable(
                name: "Directions");
        }
    }
}
