﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1Library.Data;

#nullable disable

namespace Project1Library.Migrations
{
    [DbContext(typeof(ApplicationDBContext.ApplicationDbContext))]
    [Migration("20240217152709_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project1Library.Data.Calcylate", b =>
                {
                    b.Property<int>("CalcylateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalcylateId"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Resultat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tal1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tal2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Valid")
                        .HasColumnType("bit");

                    b.HasKey("CalcylateId");

                    b.ToTable("Calcylate");
                });

            modelBuilder.Entity("Project1Library.Data.RockPaperScissor", b =>
                {
                    b.Property<int>("RPSId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RPSId"));

                    b.Property<string>("DatornsDrag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Förlust")
                        .HasColumnType("int");

                    b.Property<decimal>("Genomsnitt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Oavgjort")
                        .HasColumnType("int");

                    b.Property<string>("Resultat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpelarensDrag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vinst")
                        .HasColumnType("int");

                    b.HasKey("RPSId");

                    b.ToTable("RockPaperScissor");
                });

            modelBuilder.Entity("Project1Library.Data.Shape", b =>
                {
                    b.Property<int>("ShapeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShapeId"));

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Base")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Circumference")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Hypotenusan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Katet1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Katet2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Lenght")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShapeForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Side")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Valid")
                        .HasColumnType("bit");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ShapeId");

                    b.ToTable("Shape");
                });
#pragma warning restore 612, 618
        }
    }
}
