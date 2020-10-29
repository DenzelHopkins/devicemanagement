﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebServerCon.Data;

namespace WebAppTest.Migrations
{
    [DbContext(typeof(WebServerContext))]
    [Migration("20201021090745_thirdCreate")]
    partial class thirdCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebServer.Models.Device", b =>
                {
                    b.Property<int>("GeräteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AusgeliehenAn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Baujahr")
                        .HasColumnType("int");

                    b.Property<string>("Bemerkung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DatumAusleihe")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Historie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modell")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seriennummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verfügbar")
                        .HasColumnType("bit");

                    b.HasKey("GeräteID");

                    b.ToTable("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
