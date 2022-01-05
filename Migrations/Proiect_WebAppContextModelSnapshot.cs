﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_WebApp.Data;

namespace Proiect_WebApp.Migrations
{
    [DbContext(typeof(Proiect_WebAppContext))]
    partial class Proiect_WebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect_WebApp.Models.Catalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("clasa")
                        .HasColumnType("int");

                    b.Property<int>("promotie")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("Proiect_WebApp.Models.Discipline", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detalii")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Discipline");
                });

            modelBuilder.Entity("Proiect_WebApp.Models.Grade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("fk_grade_discipline")
                        .HasColumnType("int");

                    b.Property<int?>("fk_grade_student")
                        .HasColumnType("int");

                    b.Property<int>("nota")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("fk_grade_discipline");

                    b.HasIndex("fk_grade_student");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("Proiect_WebApp.Models.School", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("School");
                });

            modelBuilder.Entity("Proiect_WebApp.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("fk_student_catalog")
                        .HasColumnType("int");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("fk_student_catalog");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Proiect_WebApp.Models.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("data_angajarii")
                        .HasColumnType("datetime2");

                    b.Property<int?>("fk_teacher_discipline")
                        .HasColumnType("int");

                    b.Property<int?>("fk_teacher_school")
                        .HasColumnType("int");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("fk_teacher_discipline");

                    b.HasIndex("fk_teacher_school");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("Proiect_WebApp.Models.Grade", b =>
                {
                    b.HasOne("Proiect_WebApp.Models.Discipline", "materie")
                        .WithMany()
                        .HasForeignKey("fk_grade_discipline");

                    b.HasOne("Proiect_WebApp.Models.Student", "elev")
                        .WithMany()
                        .HasForeignKey("fk_grade_student");
                });

            modelBuilder.Entity("Proiect_WebApp.Models.Student", b =>
                {
                    b.HasOne("Proiect_WebApp.Models.Catalog", "catalog")
                        .WithMany()
                        .HasForeignKey("fk_student_catalog");
                });

            modelBuilder.Entity("Proiect_WebApp.Models.Teacher", b =>
                {
                    b.HasOne("Proiect_WebApp.Models.Discipline", "materie")
                        .WithMany()
                        .HasForeignKey("fk_teacher_discipline");

                    b.HasOne("Proiect_WebApp.Models.School", "scoala")
                        .WithMany()
                        .HasForeignKey("fk_teacher_school");
                });
#pragma warning restore 612, 618
        }
    }
}
