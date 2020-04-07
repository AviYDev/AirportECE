﻿// <auto-generated />
using System;
using IA.MyAirport.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IA.MyAirport.EF.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    [Migration("20200401094552_Test")]
    partial class Test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IA.MyAirport.EF.Bagage", b =>
                {
                    b.Property<int>("BagageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("VolId")
                        .HasColumnType("int");

                    b.Property<string>("classe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("code_iata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date_creation")
                        .IsRequired()
                        .HasColumnType("char(12)");

                    b.Property<string>("destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("escale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("prioritaire")
                        .HasColumnType("bit");

                    b.Property<string>("ssur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sta")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("BagageId");

                    b.HasIndex("VolId");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("IA.MyAirport.EF.Vol", b =>
                {
                    b.Property<int>("VolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("des")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dhc")
                        .HasColumnType("datetime2");

                    b.Property<string>("imm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("pax")
                        .HasColumnType("smallint");

                    b.Property<string>("pkg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VolId");

                    b.ToTable("Vols");
                });

            modelBuilder.Entity("IA.MyAirport.EF.Bagage", b =>
                {
                    b.HasOne("IA.MyAirport.EF.Vol", "Vol")
                        .WithMany("bagages")
                        .HasForeignKey("VolId");
                });
#pragma warning restore 612, 618
        }
    }
}
