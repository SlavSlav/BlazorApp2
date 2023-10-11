using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    public partial class AddCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_CompanyModel_CompanyId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyModel",
                table: "CompanyModel");

            migrationBuilder.RenameTable(
                name: "CompanyModel",
                newName: "Company");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Company_CompanyId",
                table: "Games",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Company_CompanyId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "CompanyModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyModel",
                table: "CompanyModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_CompanyModel_CompanyId",
                table: "Games",
                column: "CompanyId",
                principalTable: "CompanyModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
