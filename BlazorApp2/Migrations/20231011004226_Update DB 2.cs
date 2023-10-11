using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    public partial class UpdateDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameModel_CompanyModel_CompanyId",
                table: "GameModel");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderModel_GameModel_GameId",
                table: "OrderModel");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderModel_Users_UserId",
                table: "OrderModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_SettingsModel_SettingsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SettingsId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderModel",
                table: "OrderModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameModel",
                table: "GameModel");

            migrationBuilder.DropColumn(
                name: "SettingsId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "OrderModel",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "GameModel",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_OrderModel_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderModel_GameId",
                table: "Orders",
                newName: "IX_Orders_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameModel_CompanyId",
                table: "Games",
                newName: "IX_Games_CompanyId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SettingsModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SettingsModel_UserId",
                table: "SettingsModel",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_CompanyModel_CompanyId",
                table: "Games",
                column: "CompanyId",
                principalTable: "CompanyModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Games_GameId",
                table: "Orders",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SettingsModel_Users_UserId",
                table: "SettingsModel",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_CompanyModel_CompanyId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Games_GameId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_SettingsModel_Users_UserId",
                table: "SettingsModel");

            migrationBuilder.DropIndex(
                name: "IX_SettingsModel_UserId",
                table: "SettingsModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SettingsModel");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "OrderModel");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "GameModel");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "OrderModel",
                newName: "IX_OrderModel_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_GameId",
                table: "OrderModel",
                newName: "IX_OrderModel_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_CompanyId",
                table: "GameModel",
                newName: "IX_GameModel_CompanyId");

            migrationBuilder.AddColumn<Guid>(
                name: "SettingsId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderModel",
                table: "OrderModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameModel",
                table: "GameModel",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SettingsId",
                table: "Users",
                column: "SettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameModel_CompanyModel_CompanyId",
                table: "GameModel",
                column: "CompanyId",
                principalTable: "CompanyModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderModel_GameModel_GameId",
                table: "OrderModel",
                column: "GameId",
                principalTable: "GameModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderModel_Users_UserId",
                table: "OrderModel",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SettingsModel_SettingsId",
                table: "Users",
                column: "SettingsId",
                principalTable: "SettingsModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
