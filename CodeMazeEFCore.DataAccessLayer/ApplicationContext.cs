using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeMazeEFCore.DataAccessLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            //modelBuilder.Entity<Student>()
            //    .ToTable("Student");

            //modelBuilder.Entity<Student>()
            //    .HasKey(s => s.StudentId);

            //modelBuilder.Entity<Student>()
            //    .Property(s => s.StudentId)
            //    .HasColumnName("StudentId");

            //modelBuilder.Entity<Student>()
            //    .Property(s => s.Name)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Student>()
            //    .Property(s => s.Age)
            //    .IsRequired(false);

            //modelBuilder.Entity<Student>()
            //    .Ignore(s => s.LocalCalculation);

            //modelBuilder.Entity<Student>()
            //    .HasIndex(s => s.Name)
            //    .HasName("idxName");

            //modelBuilder.Entity<Student>()
            //    .Property(s => s.IsRegularStudent)
            //    .HasDefaultValue(true);

            //modelBuilder.Entity<Student>()
            //    .HasData(
            //    new Student
            //    {
            //        StudentId = Guid.NewGuid(),
            //        Name = "John Doe",
            //        Age = 30
            //    },
            //    new Student
            //    {
            //        StudentId = Guid.NewGuid(),
            //        Name = "Jane Doe",
            //        Age = 25
            //    }
            //    );

        }
    }
}
