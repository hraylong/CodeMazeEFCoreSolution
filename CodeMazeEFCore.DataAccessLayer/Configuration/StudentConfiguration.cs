﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace CodeMazeEFCore.DataAccessLayer
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student", "Common");

            builder.Property(s => s.Age)
                .IsRequired(false);

            builder.Property(s => s.IsRegularStudent)
                .HasDefaultValue(true);

            builder.HasData
            (
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    Name = "John Doe",
                    Age = 30
                },
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    Name = "Jane Doe",
                    Age = 25
                },
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    Name = "Mike Miles",
                    Age = 28
                },
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    Name = "TEST Name",
                    Age = 100
                }
            );
        }
    }
}
