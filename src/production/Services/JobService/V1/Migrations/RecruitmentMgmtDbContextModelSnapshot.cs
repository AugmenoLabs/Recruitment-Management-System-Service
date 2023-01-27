﻿// <auto-generated />
using System;
using JobService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JobService.V1.Migrations
{
    [DbContext(typeof(RecruitmentMgmtDbContext))]
    partial class RecruitmentMgmtDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("JobService.V1.Models.Job", b =>
                {
                    b.Property<string>("JobTitle")
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("JobId")
                        .HasColumnType("bigint");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("NoOfPositions")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Qualification")
                        .HasColumnType("text");

                    b.Property<string>("SkillSet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("YearOfExp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("JobTitle");

                    b.HasIndex("JobId")
                        .IsUnique();

                    b.ToTable("jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
