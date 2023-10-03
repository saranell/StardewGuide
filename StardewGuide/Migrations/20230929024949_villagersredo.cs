using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StardewGuide.Migrations
{
    /// <inheritdoc />
    public partial class villagersredo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Villagers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Villagers");

            migrationBuilder.AlterColumn<string>(
                name: "ImageFileName",
                table: "Villagers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villagers",
                keyColumn: "ImageFileName",
                keyValue: null,
                column: "ImageFileName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImageFileName",
                table: "Villagers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "Villagers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Villagers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
