﻿// <auto-generated />
using IM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IM.Infrastructure.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IM.Domain.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });
#pragma warning restore 612, 618
        }
    }
}