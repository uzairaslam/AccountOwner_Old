﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCoreSeries.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200405210021_AdditionalRowInserted")]
    partial class AdditionalRowInserted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsRegularStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("StudentId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Age = 30,
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            StudentId = 2,
                            Age = 25,
                            IsRegularStudent = false,
                            Name = "Jane Doe"
                        },
                        new
                        {
                            StudentId = 4,
                            Age = 28,
                            IsRegularStudent = false,
                            Name = "Mike Miles"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
