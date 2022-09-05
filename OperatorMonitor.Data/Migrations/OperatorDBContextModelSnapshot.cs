﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OperatorMonitor.Data.Context;

namespace OperatorMonitor.Data.Migrations
{
    [DbContext(typeof(OperatorDBContext))]
    partial class OperatorDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OperatorMonitor.Entity.OperationLog", b =>
                {
                    b.Property<long>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessDirection")
                        .HasColumnType("int");

                    b.Property<string>("AccessLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdditionalInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("ComputerHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime>("LogTime")
                        .HasColumnType("datetime");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("VerifyStatusCode")
                        .HasColumnType("int");

                    b.HasKey("LogID");

                    b.ToTable("tblOperationLog");
                });
#pragma warning restore 612, 618
        }
    }
}
