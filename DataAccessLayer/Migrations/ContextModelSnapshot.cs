﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AboutDetails")
                        .HasColumnType("text");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("text");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("text");

                    b.Property<string>("AboutTitle2")
                        .HasColumnType("text");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ContactMail")
                        .HasColumnType("text");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("text");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("text");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("text");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ContactLocation", b =>
                {
                    b.Property<int>("ContactLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactAdress")
                        .HasColumnType("text");

                    b.Property<string>("ContactEMail")
                        .HasColumnType("text");

                    b.Property<string>("ContactMapLocation")
                        .HasColumnType("text");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("text");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("text");

                    b.Property<string>("ContactTitle2")
                        .HasColumnType("text");

                    b.HasKey("ContactLocationId");

                    b.ToTable("ContactLocations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MyProject", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ProjectDetails")
                        .HasColumnType("text");

                    b.Property<string>("ProjectImage")
                        .HasColumnType("text");

                    b.Property<string>("ProjectKategori")
                        .HasColumnType("text");

                    b.Property<bool>("ProjectStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProjectTitle")
                        .HasColumnType("text");

                    b.Property<string>("ProjectTitle2")
                        .HasColumnType("text");

                    b.HasKey("ProjectId");

                    b.ToTable("MyProjects");
                });

            modelBuilder.Entity("EntityLayer.Concrete.UserAdmin", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserMail")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserPassword")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("UserAdmins");
                });
#pragma warning restore 612, 618
        }
    }
}
