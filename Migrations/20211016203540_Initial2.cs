using Microsoft.EntityFrameworkCore.Migrations;

namespace AvaliaçãoTecnobyte.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CpfCnpj",
                table: "People",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_CpfCnpj",
                table: "People",
                column: "CpfCnpj",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_People_CpfCnpj",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                table: "People",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
