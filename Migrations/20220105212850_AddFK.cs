using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_WebApp.Migrations
{
    public partial class AddFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scoala",
                table: "Teacher");

            migrationBuilder.AddColumn<int>(
                name: "ScoalaID",
                table: "Teacher",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_MaterieID",
                table: "Teacher",
                column: "MaterieID");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_ScoalaID",
                table: "Teacher",
                column: "ScoalaID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CatalogID",
                table: "Student",
                column: "CatalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_ElevID",
                table: "Grade",
                column: "ElevID");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_MaterieID",
                table: "Grade",
                column: "MaterieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Student_ElevID",
                table: "Grade",
                column: "ElevID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Discipline_MaterieID",
                table: "Grade",
                column: "MaterieID",
                principalTable: "Discipline",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Catalog_CatalogID",
                table: "Student",
                column: "CatalogID",
                principalTable: "Catalog",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Discipline_MaterieID",
                table: "Teacher",
                column: "MaterieID",
                principalTable: "Discipline",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_School_ScoalaID",
                table: "Teacher",
                column: "ScoalaID",
                principalTable: "School",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Student_ElevID",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Discipline_MaterieID",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Catalog_CatalogID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Discipline_MaterieID",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_School_ScoalaID",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_MaterieID",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_ScoalaID",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Student_CatalogID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Grade_ElevID",
                table: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Grade_MaterieID",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "ScoalaID",
                table: "Teacher");

            migrationBuilder.AddColumn<int>(
                name: "Scoala",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
