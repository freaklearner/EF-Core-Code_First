﻿// <auto-generated />
using System;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Migrations
{
    [DbContext(typeof(Model))]
    [Migration("20191111162004_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("EFCore.Models.Books", b =>
                {
                    b.Property<string>("ISBN")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Languages");

                    b.Property<int>("Pages");

                    b.Property<int?>("PublisherId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ISBN");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EFCore.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("EFCore.Models.Books", b =>
                {
                    b.HasOne("EFCore.Models.Publisher", "Publisher")
                        .WithMany("BooksList")
                        .HasForeignKey("PublisherId");
                });
#pragma warning restore 612, 618
        }
    }
}
