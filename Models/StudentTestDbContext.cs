using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentTest.Models;

public partial class StudentTestDbContext : DbContext
{
    

    public StudentTestDbContext(DbContextOptions<StudentTestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__students__4D11D63CE6D07128");

            entity.ToTable("students");

            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.StudentAdd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("studentAdd");
            entity.Property(e => e.StudentClass)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("studentClass");
            entity.Property(e => e.StudentName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("studentName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
