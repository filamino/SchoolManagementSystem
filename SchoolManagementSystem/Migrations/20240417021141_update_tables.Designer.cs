﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagementSystem.Data;

#nullable disable

namespace SchoolManagementSystem.Migrations
{
    [DbContext(typeof(SmsdbContext))]
    [Migration("20240417021141_update_tables")]
    partial class update_tables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("Address1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Address");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Province")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AddressId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"));

                    b.Property<string>("Class1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Class");

                    b.HasKey("ClassId");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Department1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Department");

                    b.Property<DateOnly?>("DepartmentStartDate")
                        .HasColumnType("date");

                    b.Property<string>("HeadOfDepartment")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NumberOfStudent")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("EventDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EventName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EventId");

                    b.ToTable("Event", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<TimeOnly?>("EndTime")
                        .HasColumnType("time");

                    b.Property<DateOnly?>("ExamDate")
                        .HasColumnType("date");

                    b.Property<string>("ExamName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<TimeOnly?>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Exam", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GenderType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("GenderId");

                    b.HasIndex("StudentId");

                    b.ToTable("Gender", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Holiday", b =>
                {
                    b.Property<int>("HolidayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HolidayId"));

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("HolidayName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int>("TypeOfHolidayId")
                        .HasColumnType("int");

                    b.HasKey("HolidayId");

                    b.HasIndex("TypeOfHolidayId");

                    b.ToTable("Holiday", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Login", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginId"));

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginId");

                    b.HasIndex("UserId");

                    b.ToTable("Login", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"));

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MobileNo")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("Profile", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Register", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Register", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SectionId"));

                    b.Property<string>("Section1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Section");

                    b.HasKey("SectionId");

                    b.ToTable("Section", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdmissionNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("image");

                    b.Property<DateOnly?>("JoinedDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubjectId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Subject", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Experience")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly?>("JoinedDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("Qualification")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TeacherNumber")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.TypeOfHoliday", b =>
                {
                    b.Property<int>("TypeOfHolidayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeOfHolidayId"));

                    b.Property<string>("TypeOfHoliday1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TypeOfHoliday");

                    b.HasKey("TypeOfHolidayId");

                    b.ToTable("TypeOfHoliday", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.StudentViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdmissionNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("JoinedDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentViewModel");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Address", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Entities.Student", "Student")
                        .WithMany("Addresses")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Address_Student");

                    b.HasOne("SchoolManagementSystem.Data.Entities.Teacher", "Teacher")
                        .WithMany("Addresses")
                        .HasForeignKey("TeacherId")
                        .IsRequired()
                        .HasConstraintName("FK_Address_Teacher");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Exam", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Entities.Department", "Department")
                        .WithMany("Exams")
                        .HasForeignKey("DepartmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Exam_Department");

                    b.HasOne("SchoolManagementSystem.Data.Entities.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_Exam_Subject");

                    b.Navigation("Department");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Gender", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Entities.Profile", "GenderNavigation")
                        .WithOne("Gender")
                        .HasForeignKey("SchoolManagementSystem.Data.Entities.Gender", "GenderId")
                        .IsRequired()
                        .HasConstraintName("FK_Gender_Profile");

                    b.HasOne("SchoolManagementSystem.Data.Entities.Teacher", "Gender1")
                        .WithOne("Gender")
                        .HasForeignKey("SchoolManagementSystem.Data.Entities.Gender", "GenderId")
                        .IsRequired()
                        .HasConstraintName("FK_Gender_Teacher");

                    b.HasOne("SchoolManagementSystem.Data.Entities.Student", "Student")
                        .WithMany("Genders")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Gender_Student");

                    b.Navigation("Gender1");

                    b.Navigation("GenderNavigation");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Holiday", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Entities.TypeOfHoliday", "TypeOfHoliday")
                        .WithMany("Holidays")
                        .HasForeignKey("TypeOfHolidayId")
                        .IsRequired()
                        .HasConstraintName("FK_Holiday_TypeOfHoliday");

                    b.Navigation("TypeOfHoliday");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Login", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Entities.Register", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Login_Register");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Profile", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Entities.Register", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Profile_Register");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Subject", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Entities.Department", "Department")
                        .WithMany("Subjects")
                        .HasForeignKey("DepartmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Subject_Department");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Department", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Profile", b =>
                {
                    b.Navigation("Gender");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Register", b =>
                {
                    b.Navigation("Logins");

                    b.Navigation("Profiles");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Student", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Genders");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Subject", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.Teacher", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Entities.TypeOfHoliday", b =>
                {
                    b.Navigation("Holidays");
                });
#pragma warning restore 612, 618
        }
    }
}
