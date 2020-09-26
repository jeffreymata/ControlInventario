﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiInventario.Features.Models;

namespace WebApiInventario.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200925062530_actualizar")]
    partial class actualizar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiInventario.Features.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Marca");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("WebApiInventario.Features.Models.EquipmentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EquipmentsId");

                    b.Property<string>("Tipo");

                    b.Property<int>("idEquipo");

                    b.Property<string>("nombreEquipo");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentsId");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("WebApiInventario.Features.Models.EquipmentDetail", b =>
                {
                    b.HasOne("WebApiInventario.Features.Models.Equipment", "Equipments")
                        .WithMany("DetailsList")
                        .HasForeignKey("EquipmentsId");
                });
#pragma warning restore 612, 618
        }
    }
}
