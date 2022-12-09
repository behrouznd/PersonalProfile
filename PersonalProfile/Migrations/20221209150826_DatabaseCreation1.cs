using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProfile.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_PersonalInfos_PersonalInfoId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_PersonalInfoId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "PersonalInfoId",
                table: "Languages");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_LanguageId",
                table: "PersonalInfos",
                column: "LanguageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_Languages_LanguageId",
                table: "PersonalInfos",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_Languages_LanguageId",
                table: "PersonalInfos");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInfos_LanguageId",
                table: "PersonalInfos");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonalInfoId",
                table: "Languages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Languages_PersonalInfoId",
                table: "Languages",
                column: "PersonalInfoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_PersonalInfos_PersonalInfoId",
                table: "Languages",
                column: "PersonalInfoId",
                principalTable: "PersonalInfos",
                principalColumn: "PersonalInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
