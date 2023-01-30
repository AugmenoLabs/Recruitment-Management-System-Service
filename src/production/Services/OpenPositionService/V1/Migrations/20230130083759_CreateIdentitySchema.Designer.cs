﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OpenPositionService;

#nullable disable

namespace OpenPositionService.V1.Migrations
{
    [DbContext(typeof(RecruitmentMgmtDbContext))]
    [Migration("20230130083759_CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OpenPositionService.V1.Models.OpenPosition", b =>
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

                    b.ToTable("OpenPositions");
                });
#pragma warning restore 612, 618
        }
    }
}
