﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Queries.Core;
using Queries.Core.Data;

namespace Queries.Core.Migrations
{
    [DbContext(typeof(PlutoContext))]
    partial class PlutoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Queries.Core.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mosh Hamedani"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Anthony Alicea"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Eric Wise"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tom Owsiak"
                        },
                        new
                        {
                            Id = 5,
                            Name = "John Smith"
                        });
                });

            modelBuilder.Entity("Queries.Core.Model.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<float>("FullPrice");

                    b.Property<int>("Level");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Description for C# Basics",
                            FullPrice = 49f,
                            Level = 1,
                            Name = "C# Basics"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "Description for C# Intermediate",
                            FullPrice = 49f,
                            Level = 2,
                            Name = "C# Intermediate"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Description = "Description for C# Advanced",
                            FullPrice = 69f,
                            Level = 3,
                            Name = "C# Advanced"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Description = "Description for Javascript",
                            FullPrice = 149f,
                            Level = 2,
                            Name = "Javascript: Understanding the Weird Parts"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 2,
                            Description = "Description for AngularJS",
                            FullPrice = 99f,
                            Level = 2,
                            Name = "Learn and Understand AngularJS"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 2,
                            Description = "Description for NodeJS",
                            FullPrice = 149f,
                            Level = 2,
                            Name = "Learn and Understand NodeJS"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 3,
                            Description = "Description for Programming for Beginners",
                            FullPrice = 45f,
                            Level = 1,
                            Name = "Programming for Complete Beginners"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 4,
                            Description = "Description 16 Hour Course",
                            FullPrice = 150f,
                            Level = 1,
                            Name = "A 16 Hour C# Course with Visual Studio 2013"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 4,
                            Description = "Description Learn Javascript",
                            FullPrice = 20f,
                            Level = 1,
                            Name = "Learn JavaScript Through Visual Studio 2013"
                        });
                });

            modelBuilder.Entity("Queries.Core.Model.CourseCover", b =>
                {
                    b.Property<int>("CourseCoverId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CoverOfCourseId");

                    b.HasKey("CourseCoverId");

                    b.HasIndex("CoverOfCourseId")
                        .IsUnique();

                    b.ToTable("CourseCovers");
                });

            modelBuilder.Entity("Queries.Core.Model.CourseTag", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<int>("TagId");

                    b.HasKey("CourseId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("CourseTags");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            TagId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            TagId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            TagId = 5
                        },
                        new
                        {
                            CourseId = 3,
                            TagId = 1
                        },
                        new
                        {
                            CourseId = 4,
                            TagId = 3
                        },
                        new
                        {
                            CourseId = 5,
                            TagId = 2
                        },
                        new
                        {
                            CourseId = 6,
                            TagId = 4
                        },
                        new
                        {
                            CourseId = 7,
                            TagId = 1
                        },
                        new
                        {
                            CourseId = 8,
                            TagId = 1
                        },
                        new
                        {
                            CourseId = 9,
                            TagId = 3
                        });
                });

            modelBuilder.Entity("Queries.Core.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Angular"
                        },
                        new
                        {
                            Id = 3,
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = 4,
                            Name = "NodeJs"
                        },
                        new
                        {
                            Id = 5,
                            Name = "OOP"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Linq"
                        });
                });

            modelBuilder.Entity("Queries.Core.Model.Course", b =>
                {
                    b.HasOne("Queries.Core.Model.Author", "Author")
                        .WithMany("Courses")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Queries.Core.Model.CourseCover", b =>
                {
                    b.HasOne("Queries.Core.Model.Course", "Course")
                        .WithOne("Cover")
                        .HasForeignKey("Queries.Core.Model.CourseCover", "CoverOfCourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Queries.Core.Model.CourseTag", b =>
                {
                    b.HasOne("Queries.Core.Model.Course", "Course")
                        .WithMany("CourseTags")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Queries.Core.Model.Tag", "Tag")
                        .WithMany("CourseTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
