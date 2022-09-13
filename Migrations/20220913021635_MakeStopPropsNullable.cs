using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD_340_W22SD_Lab_3.Migrations
{
    public partial class MakeStopPropsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stop_Directions_DirectionId",
                table: "Stop");

            migrationBuilder.AlterColumn<int>(
                name: "DirectionId",
                table: "Stop",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Stop_Directions_DirectionId",
                table: "Stop",
                column: "DirectionId",
                principalTable: "Directions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stop_Directions_DirectionId",
                table: "Stop");

            migrationBuilder.AlterColumn<int>(
                name: "DirectionId",
                table: "Stop",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stop_Directions_DirectionId",
                table: "Stop",
                column: "DirectionId",
                principalTable: "Directions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
