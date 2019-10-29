using Microsoft.EntityFrameworkCore.Migrations;

namespace AppServices.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserID",
                table: "Apps",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Apps_ApplicationUserID",
                table: "Apps",
                column: "ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apps_AspNetUsers_ApplicationUserID",
                table: "Apps",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apps_AspNetUsers_ApplicationUserID",
                table: "Apps");

            migrationBuilder.DropIndex(
                name: "IX_Apps_ApplicationUserID",
                table: "Apps");

            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "Apps");
        }
    }
}
