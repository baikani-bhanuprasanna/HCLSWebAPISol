﻿// <auto-generated />
using HCLSWebAPI.HCLSContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HCLSWebAPI.Migrations
{
    [DbContext(typeof(HCLSContextPro))]
    [Migration("20240811105707_HCLSProjDatabaseCreation")]
    partial class HCLSProjDatabaseCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HCLSWebAPI.Models.Admin", b =>
                {
                    b.Property<int>("AdminTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdminTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminTypeId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("HCLSWebAPI.Models.AdminDetail", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdminTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.HasIndex("AdminTypeId");

                    b.ToTable("AdminDetail");
                });

            modelBuilder.Entity("HCLSWebAPI.Models.AdminDetail", b =>
                {
                    b.HasOne("HCLSWebAPI.Models.Admin", "Admin")
                        .WithMany("AdminDetail")
                        .HasForeignKey("AdminTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("HCLSWebAPI.Models.Admin", b =>
                {
                    b.Navigation("AdminDetail");
                });
#pragma warning restore 612, 618
        }
    }
}