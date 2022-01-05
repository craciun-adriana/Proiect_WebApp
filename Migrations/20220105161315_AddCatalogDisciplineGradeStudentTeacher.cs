using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_WebApp.Migrations
{
    public partial class AddCatalogDisciplineGradeStudentTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telefon",
                table: "School",
                newName: "Telefon");

            migrationBuilder.RenameColumn(
                name: "denumire",
                table: "School",
                newName: "Denumire");

            migrationBuilder.RenameColumn(
                name: "adresa",
                table: "School",
                newName: "Adresa");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "School",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Catalog",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clasa = table.Column<int>(nullable: false),
                    Promotie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(nullable: true),
                    Detalii = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    MaterieID = table.Column<int>(nullable: false),
                    ElevID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    CatalogID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Data_angajarii = table.Column<DateTime>(nullable: false),
                    Scoala = table.Column<int>(nullable: false),
                    MaterieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog");

            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "School",
                newName: "telefon");

            migrationBuilder.RenameColumn(
                name: "Denumire",
                table: "School",
                newName: "denumire");

            migrationBuilder.RenameColumn(
                name: "Adresa",
                table: "School",
                newName: "adresa");

            migrationBuilder.AlterColumn<int>(
                name: "telefon",
                table: "School",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
