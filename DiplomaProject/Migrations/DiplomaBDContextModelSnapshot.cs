﻿// <auto-generated />
using System;
using DiplomaProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiplomaProject.Migrations
{
    [DbContext(typeof(DiplomaBDContext))]
    partial class DiplomaBDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiplomaProject.Model.BackupLessons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ExpireDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NextLessonTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("BackupLessons");
                });

            modelBuilder.Entity("DiplomaProject.Model.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameOfDiscipline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("DiplomaProject.Model.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GroupNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DiplomaProject.Model.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<string>("Discipline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfLesson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("TimeOfLesson")
                        .HasColumnType("time");

                    b.Property<string>("TypeOfLesson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfWeek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("DiplomaProject.Model.PlaceOfLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PlaceOfLessons");
                });

            modelBuilder.Entity("DiplomaProject.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Departmant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobPost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DiplomaProject.Model.Workload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("Disciplenes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfLesson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Workloads");
                });

            modelBuilder.Entity("DiplomaProject.Model.BackupLessons", b =>
                {
                    b.HasOne("DiplomaProject.Model.Lesson", "Lesson")
                        .WithMany("BackupLessons")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("DiplomaProject.Model.Discipline", b =>
                {
                    b.HasOne("DiplomaProject.Model.User", "User")
                        .WithMany("Discipline")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiplomaProject.Model.Group", b =>
                {
                    b.HasOne("DiplomaProject.Model.User", "User")
                        .WithMany("Group")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiplomaProject.Model.Lesson", b =>
                {
                    b.HasOne("DiplomaProject.Model.User", "User")
                        .WithMany("Lesson")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiplomaProject.Model.PlaceOfLesson", b =>
                {
                    b.HasOne("DiplomaProject.Model.User", "User")
                        .WithMany("PlaceOfLesson")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiplomaProject.Model.Workload", b =>
                {
                    b.HasOne("DiplomaProject.Model.Lesson", "Lesson")
                        .WithMany("Workload")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("DiplomaProject.Model.Lesson", b =>
                {
                    b.Navigation("BackupLessons");

                    b.Navigation("Workload");
                });

            modelBuilder.Entity("DiplomaProject.Model.User", b =>
                {
                    b.Navigation("Discipline");

                    b.Navigation("Group");

                    b.Navigation("Lesson");

                    b.Navigation("PlaceOfLesson");
                });
#pragma warning restore 612, 618
        }
    }
}
