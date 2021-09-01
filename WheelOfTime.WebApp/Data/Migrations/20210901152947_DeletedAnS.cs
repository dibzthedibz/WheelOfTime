using Microsoft.EntityFrameworkCore.Migrations;

namespace WheelOfTime.WebApp.Data.Migrations
{
    public partial class DeletedAnS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chapterss",
                table: "Chapterss");

            migrationBuilder.RenameTable(
                name: "Chapterss",
                newName: "Chapters");

            migrationBuilder.RenameIndex(
                name: "IX_Chapterss_NationId",
                table: "Chapters",
                newName: "IX_Chapters_NationId");

            migrationBuilder.RenameIndex(
                name: "IX_Chapterss_CharacterId",
                table: "Chapters",
                newName: "IX_Chapters_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Chapterss_BookId",
                table: "Chapters",
                newName: "IX_Chapters_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chapters",
                table: "Chapters",
                column: "ChapterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Books_BookId",
                table: "Chapters",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Characters_CharacterId",
                table: "Chapters",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Nations_NationId",
                table: "Chapters",
                column: "NationId",
                principalTable: "Nations",
                principalColumn: "NationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Books_BookId",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Characters_CharacterId",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Nations_NationId",
                table: "Chapters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chapters",
                table: "Chapters");

            migrationBuilder.RenameTable(
                name: "Chapters",
                newName: "Chapterss");

            migrationBuilder.RenameIndex(
                name: "IX_Chapters_NationId",
                table: "Chapterss",
                newName: "IX_Chapterss_NationId");

            migrationBuilder.RenameIndex(
                name: "IX_Chapters_CharacterId",
                table: "Chapterss",
                newName: "IX_Chapterss_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Chapters_BookId",
                table: "Chapterss",
                newName: "IX_Chapterss_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chapterss",
                table: "Chapterss",
                column: "ChapterId");

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
        }
    }
}
