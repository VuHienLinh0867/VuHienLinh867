﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace VuHienLinh867.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20211215061820_Create_Table_CompanyVHL867")]
    partial class Create_Table_CompanyVHL867
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("VUHIENLINH867.Models.CompanyVHL867", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("CompanyVHL867");
                });
#pragma warning restore 612, 618
        }
    }
}
