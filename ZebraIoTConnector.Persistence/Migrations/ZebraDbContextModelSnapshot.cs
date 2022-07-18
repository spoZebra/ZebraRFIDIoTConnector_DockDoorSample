﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZebraIoTConnector.Persistence;

#nullable disable

namespace ZebraIoTConnector.Persistence.Migrations
{
    [DbContext(typeof(ZebraDbContext))]
    partial class ZebraDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ZebraIoTConnector.Persistence.Entities.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ReferenceStorageUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ReferenceStorageUnitId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("ZebraIoTConnector.Persistence.Entities.InventoryOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("StorageUnitFromId")
                        .HasColumnType("int");

                    b.Property<int>("StorageUnitToId")
                        .HasColumnType("int");

                    b.Property<int>("SublotId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("StorageUnitFromId");

                    b.HasIndex("StorageUnitToId");

                    b.HasIndex("SublotId");

                    b.ToTable("InventoryOperation");
                });

            modelBuilder.Entity("ZebraIoTConnector.Persistence.Entities.StorageUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Direction")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("StorageUnits");
                });

            modelBuilder.Entity("ZebraIoTConnector.Persistence.Entities.Sublot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BatchNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaterialId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StorageUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Identifier")
                        .IsUnique();

                    b.HasIndex("StorageUnitId");

                    b.ToTable("Sublots");
                });

            modelBuilder.Entity("ZebraIoTConnector.Persistence.Entities.Equipment", b =>
                {
                    b.HasOne("ZebraIoTConnector.Persistence.Entities.StorageUnit", "ReferenceStorageUnit")
                        .WithMany()
                        .HasForeignKey("ReferenceStorageUnitId");

                    b.Navigation("ReferenceStorageUnit");
                });

            modelBuilder.Entity("ZebraIoTConnector.Persistence.Entities.InventoryOperation", b =>
                {
                    b.HasOne("ZebraIoTConnector.Persistence.Entities.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZebraIoTConnector.Persistence.Entities.StorageUnit", "StorageUnitFrom")
                        .WithMany()
                        .HasForeignKey("StorageUnitFromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZebraIoTConnector.Persistence.Entities.StorageUnit", "StorageUnitTo")
                        .WithMany()
                        .HasForeignKey("StorageUnitToId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZebraIoTConnector.Persistence.Entities.Sublot", "Sublot")
                        .WithMany()
                        .HasForeignKey("SublotId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("StorageUnitFrom");

                    b.Navigation("StorageUnitTo");

                    b.Navigation("Sublot");
                });

            modelBuilder.Entity("ZebraIoTConnector.Persistence.Entities.Sublot", b =>
                {
                    b.HasOne("ZebraIoTConnector.Persistence.Entities.StorageUnit", "StorageUnit")
                        .WithMany()
                        .HasForeignKey("StorageUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StorageUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
