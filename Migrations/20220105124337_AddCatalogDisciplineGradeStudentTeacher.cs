using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_WebApp.Migrations
{
    public partial class AddCatalogDisciplineGradeStudentTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "telefon",
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
                    clasa = table.Column<int>(nullable: false),
                    promotie = table.Column<int>(nullable: false)
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
                    denumire = table.Column<string>(nullable: true),
                    detalii = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(nullable: true),
                    prenume = table.Column<string>(nullable: true),
                    telefon = table.Column<string>(nullable: true),
                    fk_student_catalog = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Student_Catalog_fk_student_catalog",
                        column: x => x.fk_student_catalog,
                        principalTable: "Catalog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(nullable: true),
                    prenume = table.Column<string>(nullable: true),
                    telefon = table.Column<string>(nullable: true),
                    data_angajarii = table.Column<DateTime>(nullable: false),
                    fk_teacher_school = table.Column<int>(nullable: true),
                    fk_teacher_discipline = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teacher_Discipline_fk_teacher_discipline",
                        column: x => x.fk_teacher_discipline,
                        principalTable: "Discipline",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teacher_School_fk_teacher_school",
                        column: x => x.fk_teacher_school,
                        principalTable: "School",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nota = table.Column<int>(nullable: false),
                    data = table.Column<DateTime>(nullable: false),
                    fk_grade_discipline = table.Column<int>(nullable: true),
                    fk_grade_student = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Grade_Discipline_fk_grade_discipline",
                        column: x => x.fk_grade_discipline,
                        principalTable: "Discipline",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grade_Student_fk_grade_student",
                        column: x => x.fk_grade_student,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grade_fk_grade_discipline",
                table: "Grade",
                column: "fk_grade_discipline");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_fk_grade_student",
                table: "Grade",
                column: "fk_grade_student");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fk_student_catalog",
                table: "Student",
                column: "fk_student_catalog");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_fk_teacher_discipline",
                table: "Teacher",
                column: "fk_teacher_discipline");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_fk_teacher_school",
                table: "Teacher",
                column: "fk_teacher_school");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "Catalog");

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
