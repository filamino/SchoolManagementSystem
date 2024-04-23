using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data.Entities;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Data;

public partial class SmsdbContext : DbContext
{
    public SmsdbContext()
    {
    }

    public SmsdbContext(DbContextOptions<SmsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }



    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Register> Registers { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TypeOfHoliday> TypeOfHolidays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .HasColumnName("Address");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ZipCode).HasMaxLength(50);

            entity.HasOne(d => d.Student).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Student");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Teacher");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.Department1)
                .HasMaxLength(50)
                .HasColumnName("Department");
            entity.Property(e => e.HeadOfDepartment).HasMaxLength(50);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("Event");

            entity.Property(e => e.EventDate).HasMaxLength(50);
            entity.Property(e => e.EventName).HasMaxLength(50);
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.ToTable("Exam");

            entity.Property(e => e.ExamName).HasMaxLength(50);

            entity.HasOne(d => d.Department).WithMany(p => p.Exams)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Exam_Department");

            entity.HasOne(d => d.Subject).WithMany(p => p.Exams)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Exam_Subject");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.ToTable("Gender");

            entity.Property(e => e.GenderId).ValueGeneratedOnAdd();
            entity.Property(e => e.GenderType).HasMaxLength(50);

            entity.HasOne(d => d.GenderNavigation).WithOne(p => p.Gender)
                .HasForeignKey<Gender>(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gender_Profile");

            entity.HasOne(d => d.Gender1).WithOne(p => p.Gender)
                .HasForeignKey<Gender>(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gender_Teacher");

            entity.HasOne(d => d.Student).WithMany(p => p.Genders)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gender_Student");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.ToTable("Holiday");

            entity.Property(e => e.HolidayName).HasMaxLength(50);

            entity.HasOne(d => d.TypeOfHoliday).WithMany(p => p.Holidays)
                .HasForeignKey(d => d.TypeOfHolidayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Holiday_TypeOfHoliday");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.ToTable("Login");

            entity.HasOne(d => d.User).WithMany(p => p.Logins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Login_Register");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.ToTable("Profile");

            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);

            entity.HasOne(d => d.User).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Profile_Register");
        });

        modelBuilder.Entity<Register>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Register");

            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.ToTable("Section");

            entity.Property(e => e.Section1)
                .HasMaxLength(50)
                .HasColumnName("Section");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.AdmissionNumber).HasMaxLength(10);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.ToTable("Subject");

            entity.Property(e => e.SubjectName).HasMaxLength(50);

            entity.HasOne(d => d.Department).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subject_Department");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.ToTable("Teacher");

            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Qualification).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeOfHoliday>(entity =>
        {
            entity.ToTable("TypeOfHoliday");

            entity.Property(e => e.TypeOfHoliday1)
                .HasMaxLength(50)
                .HasColumnName("TypeOfHoliday");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<SchoolManagementSystem.Models.StudentViewModel> StudentViewModel { get; set; } = default!;
}
