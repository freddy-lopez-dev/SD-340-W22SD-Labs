using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD_340_W22SD_Lab_3.Migrations
{
    public partial class MakeNullableValueOnRoute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Route_Direction_DirectionId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledStop_Route_RouteId",
                table: "ScheduledStop");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledStop_Stop_StopId",
                table: "ScheduledStop");

            migrationBuilder.DropForeignKey(
                name: "FK_Stop_Direction_DirectionId",
                table: "Stop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScheduledStop",
                table: "ScheduledStop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Route",
                table: "Route");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Direction",
                table: "Direction");

            migrationBuilder.RenameTable(
                name: "ScheduledStop",
                newName: "ScheduledStops");

            migrationBuilder.RenameTable(
                name: "Route",
                newName: "Routes");

            migrationBuilder.RenameTable(
                name: "Direction",
                newName: "Directions");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduledStop_StopId",
                table: "ScheduledStops",
                newName: "IX_ScheduledStops_StopId");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduledStop_RouteId",
                table: "ScheduledStops",
                newName: "IX_ScheduledStops_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_Route_DirectionId",
                table: "Routes",
                newName: "IX_Routes_DirectionId");

            migrationBuilder.AlterColumn<bool>(
                name: "RampAccessible",
                table: "Routes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "DirectionId",
                table: "Routes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "BicycleAccessible",
                table: "Routes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScheduledStops",
                table: "ScheduledStops",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Routes",
                table: "Routes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directions",
                table: "Directions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Directions_DirectionId",
                table: "Routes",
                column: "DirectionId",
                principalTable: "Directions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledStops_Routes_RouteId",
                table: "ScheduledStops",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledStops_Stop_StopId",
                table: "ScheduledStops",
                column: "StopId",
                principalTable: "Stop",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stop_Directions_DirectionId",
                table: "Stop",
                column: "DirectionId",
                principalTable: "Directions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Directions_DirectionId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledStops_Routes_RouteId",
                table: "ScheduledStops");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledStops_Stop_StopId",
                table: "ScheduledStops");

            migrationBuilder.DropForeignKey(
                name: "FK_Stop_Directions_DirectionId",
                table: "Stop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScheduledStops",
                table: "ScheduledStops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Routes",
                table: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directions",
                table: "Directions");

            migrationBuilder.RenameTable(
                name: "ScheduledStops",
                newName: "ScheduledStop");

            migrationBuilder.RenameTable(
                name: "Routes",
                newName: "Route");

            migrationBuilder.RenameTable(
                name: "Directions",
                newName: "Direction");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduledStops_StopId",
                table: "ScheduledStop",
                newName: "IX_ScheduledStop_StopId");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduledStops_RouteId",
                table: "ScheduledStop",
                newName: "IX_ScheduledStop_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_Routes_DirectionId",
                table: "Route",
                newName: "IX_Route_DirectionId");

            migrationBuilder.AlterColumn<bool>(
                name: "RampAccessible",
                table: "Route",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DirectionId",
                table: "Route",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "BicycleAccessible",
                table: "Route",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScheduledStop",
                table: "ScheduledStop",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Route",
                table: "Route",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Direction",
                table: "Direction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Direction_DirectionId",
                table: "Route",
                column: "DirectionId",
                principalTable: "Direction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledStop_Route_RouteId",
                table: "ScheduledStop",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledStop_Stop_StopId",
                table: "ScheduledStop",
                column: "StopId",
                principalTable: "Stop",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stop_Direction_DirectionId",
                table: "Stop",
                column: "DirectionId",
                principalTable: "Direction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
