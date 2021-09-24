﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    partial class TARge20DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.Absence", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Reason")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("WorkerID");

                    b.ToTable("Absences");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Child", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("WorkerID");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("TARge20.Core.Domain.CookID", b =>
                {
                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FirstName");

                    b.HasIndex("WorkerID");

                    b.ToTable("CookIDs");
                });

            modelBuilder.Entity("TARge20.Core.Domain.EatingHistory", b =>
                {
                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Dish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Portions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Date");

                    b.HasIndex("WorkerID");

                    b.ToTable("EatingHistories");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Group", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GroupType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfPeople")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("WorkerID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("TARge20.Core.Domain.KitchenMenu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("WorkerID");

                    b.ToTable("KitchenMenus");
                });

            modelBuilder.Entity("TARge20.Core.Domain.PositionID", b =>
                {
                    b.Property<string>("PositionType")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PositionType");

                    b.HasIndex("WorkerID");

                    b.ToTable("PositionIDs");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacation", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("WorkerID");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Worker", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("WorkerID");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("TARge20.Core.Domain.WorkerProffession", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WorkerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("WorkerID");

                    b.ToTable("WorkerProffessions");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Absence", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("Absence_ID")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Child", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("Children_ID")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.CookID", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("Cook_IDs")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.EatingHistory", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("EatingHistory_ID")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Group", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("Group_ID")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.KitchenMenu", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("KitchenMenu_ID")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.PositionID", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("Position_IDs")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacation", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("Vacations_ID")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Worker", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("Workers_ID")
                        .HasForeignKey("WorkerID");
                });

            modelBuilder.Entity("TARge20.Core.Domain.WorkerProffession", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Worker", null)
                        .WithMany("WorkerProffession_ID")
                        .HasForeignKey("WorkerID");
                });
#pragma warning restore 612, 618
        }
    }
}
