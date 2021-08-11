using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WheelOfTime.WebApp.Data.Migrations
{
    public partial class ObjectsPopulated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Nations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationName",
                table: "Nations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Nations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Terrain",
                table: "Nations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Trades",
                table: "Nations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ability",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NationId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Chapterss",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookIn",
                table: "Chapterss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChapNum",
                table: "Chapterss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ChapTitle",
                table: "Chapterss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Chapterss",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Chapterss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Narrator",
                table: "Chapterss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationId",
                table: "Chapterss",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Chapterss",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "PageCount",
                table: "Chapterss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "PageCount",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Nations_BookId",
                table: "Nations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BookId",
                table: "Characters",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_NationId",
                table: "Characters",
                column: "NationId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapterss_BookId",
                table: "Chapterss",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapterss_CharacterId",
                table: "Chapterss",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapterss_NationId",
                table: "Chapterss",
                column: "NationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapterss_Books_BookId",
                table: "Chapterss",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapterss_Characters_CharacterId",
                table: "Chapterss",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapterss_Nations_NationId",
                table: "Chapterss",
                column: "NationId",
                principalTable: "Nations",
                principalColumn: "NationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Books_BookId",
                table: "Characters",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Nations_NationId",
                table: "Characters",
                column: "NationId",
                principalTable: "Nations",
                principalColumn: "NationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nations_Books_BookId",
                table: "Nations",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapterss_Books_BookId",
                table: "Chapterss");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapterss_Characters_CharacterId",
                table: "Chapterss");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapterss_Nations_NationId",
                table: "Chapterss");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Books_BookId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Nations_NationId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Nations_Books_BookId",
                table: "Nations");

            migrationBuilder.DropIndex(
                name: "IX_Nations_BookId",
                table: "Nations");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BookId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_NationId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Chapterss_BookId",
                table: "Chapterss");

            migrationBuilder.DropIndex(
                name: "IX_Chapterss_CharacterId",
                table: "Chapterss");

            migrationBuilder.DropIndex(
                name: "IX_Chapterss_NationId",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Nations");

            migrationBuilder.DropColumn(
                name: "NationName",
                table: "Nations");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Nations");

            migrationBuilder.DropColumn(
                name: "Terrain",
                table: "Nations");

            migrationBuilder.DropColumn(
                name: "Trades",
                table: "Nations");

            migrationBuilder.DropColumn(
                name: "Ability",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "NationId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "BookIn",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "ChapNum",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "ChapTitle",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "Narrator",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "NationId",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "PageCount",
                table: "Chapterss");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PageCount",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Books");
        }
    }
}
