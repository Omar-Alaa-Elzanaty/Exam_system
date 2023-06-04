﻿// <auto-generated />
using Examsystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examsystem.Migrations
{
    [DbContext(typeof(ExamDb))]
    [Migration("20230529163034_initialcreation")]
    partial class initialcreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examsystem.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("userName")
                        .IsUnique();

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("Examsystem.Models.Exam", b =>
                {
                    b.Property<int>("examId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("examId"));

                    b.Property<int>("durationInMinute")
                        .HasColumnType("int");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.Property<int>("teacherId")
                        .HasColumnType("int");

                    b.HasKey("examId");

                    b.HasIndex("teacherId");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("Examsystem.Models.Question", b =>
                {
                    b.Property<int>("questionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("questionId"));

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("choicA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("choicB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("choicC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("choicD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("examId")
                        .HasColumnType("int");

                    b.Property<string>("question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("questionId");

                    b.HasIndex("examId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Examsystem.Models.Result", b =>
                {
                    b.Property<int>("sId")
                        .HasColumnType("int");

                    b.Property<int>("examId")
                        .HasColumnType("int");

                    b.Property<double>("result")
                        .HasColumnType("float");

                    b.HasKey("sId", "examId");

                    b.HasIndex("examId");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("Examsystem.Models.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentId"));

                    b.Property<int>("accId")
                        .HasColumnType("int");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.HasKey("studentId");

                    b.HasIndex("accId")
                        .IsUnique();

                    b.ToTable("students");
                });

            modelBuilder.Entity("Examsystem.Models.Teacher", b =>
                {
                    b.Property<int>("teacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teacherId"));

                    b.Property<int>("accId")
                        .HasColumnType("int");

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teacherId");

                    b.HasIndex("accId")
                        .IsUnique();

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("Examsystem.Models.Exam", b =>
                {
                    b.HasOne("Examsystem.Models.Teacher", "teacher")
                        .WithMany("exams")
                        .HasForeignKey("teacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("Examsystem.Models.Question", b =>
                {
                    b.HasOne("Examsystem.Models.Exam", "exam")
                        .WithMany("questions")
                        .HasForeignKey("examId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exam");
                });

            modelBuilder.Entity("Examsystem.Models.Result", b =>
                {
                    b.HasOne("Examsystem.Models.Exam", "exam")
                        .WithMany("results")
                        .HasForeignKey("examId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Examsystem.Models.Student", "student")
                        .WithMany("results")
                        .HasForeignKey("sId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exam");

                    b.Navigation("student");
                });

            modelBuilder.Entity("Examsystem.Models.Student", b =>
                {
                    b.HasOne("Examsystem.Models.Account", "account")
                        .WithOne("student")
                        .HasForeignKey("Examsystem.Models.Student", "accId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("Examsystem.Models.Teacher", b =>
                {
                    b.HasOne("Examsystem.Models.Account", "account")
                        .WithOne("teacher")
                        .HasForeignKey("Examsystem.Models.Teacher", "accId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("Examsystem.Models.Account", b =>
                {
                    b.Navigation("student")
                        .IsRequired();

                    b.Navigation("teacher")
                        .IsRequired();
                });

            modelBuilder.Entity("Examsystem.Models.Exam", b =>
                {
                    b.Navigation("questions");

                    b.Navigation("results");
                });

            modelBuilder.Entity("Examsystem.Models.Student", b =>
                {
                    b.Navigation("results");
                });

            modelBuilder.Entity("Examsystem.Models.Teacher", b =>
                {
                    b.Navigation("exams");
                });
#pragma warning restore 612, 618
        }
    }
}
