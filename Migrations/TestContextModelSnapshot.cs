﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication11.Context;

#nullable disable

namespace WebApplication11.Migrations
{
    [DbContext(typeof(TestContext))]
    partial class TestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication11.Models.TestModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
