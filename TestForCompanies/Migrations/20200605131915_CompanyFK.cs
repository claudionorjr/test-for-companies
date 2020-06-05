using Microsoft.EntityFrameworkCore.Migrations;

namespace TestForCompanies.Migrations
{
    public partial class CompanyFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purveyor_Company_CompanyId",
                table: "Purveyor");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Purveyor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Purveyor_Company_CompanyId",
                table: "Purveyor",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purveyor_Company_CompanyId",
                table: "Purveyor");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Purveyor",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Purveyor_Company_CompanyId",
                table: "Purveyor",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
