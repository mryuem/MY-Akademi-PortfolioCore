using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCore.Migrations
{
    public partial class mig_Icons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccounts_Icon_IconId",
                table: "SocialAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Icon",
                table: "Icon");

            migrationBuilder.RenameTable(
                name: "Icon",
                newName: "Icons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Icons",
                table: "Icons",
                column: "IconId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccounts_Icons_IconId",
                table: "SocialAccounts",
                column: "IconId",
                principalTable: "Icons",
                principalColumn: "IconId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccounts_Icons_IconId",
                table: "SocialAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Icons",
                table: "Icons");

            migrationBuilder.RenameTable(
                name: "Icons",
                newName: "Icon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Icon",
                table: "Icon",
                column: "IconId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccounts_Icon_IconId",
                table: "SocialAccounts",
                column: "IconId",
                principalTable: "Icon",
                principalColumn: "IconId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
