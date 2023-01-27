using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobService.V1.Migrations
{
    /// <inheritdoc />
    public partial class CreatedJobSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    JobTitle = table.Column<string>(type: "text", nullable: false),
                    JobId = table.Column<long>(type: "bigint", nullable: false),
                    SkillSet = table.Column<string>(type: "text", nullable: false),
                    YearOfExp = table.Column<string>(type: "text", nullable: false),
                    Qualification = table.Column<string>(type: "text", nullable: true),
                    JobDescription = table.Column<string>(type: "text", nullable: false),
                    NoOfPositions = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    PostedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.JobTitle);
                });

            migrationBuilder.CreateIndex(
                name: "IX_jobs_JobId",
                table: "jobs",
                column: "JobId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jobs");
        }
    }
}
