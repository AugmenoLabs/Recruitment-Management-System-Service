using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RecruitmentManagementSystemDb.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<string>(type: "text", nullable: false),
                    AccountName = table.Column<string>(type: "text", nullable: false),
                    AccountDetails = table.Column<string>(type: "text", nullable: false),
                    AccountManager = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "CandidateProfiles",
                columns: table => new
                {
                    CandidateID = table.Column<string>(type: "text", nullable: false),
                    CandidateName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    ContactNumber = table.Column<long>(type: "bigint", nullable: false),
                    ResidentialAddress = table.Column<string>(type: "text", nullable: false),
                    PermanenetAddress = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    MaritalStatus = table.Column<string>(type: "text", nullable: false),
                    YearOfExperience = table.Column<string>(type: "text", nullable: false),
                    PrimarySkills = table.Column<string>(type: "text", nullable: false),
                    SecondarySkills = table.Column<string>(type: "text", nullable: false),
                    JobID = table.Column<long>(type: "bigint", nullable: false),
                    CurrentCTC = table.Column<string>(type: "text", nullable: false),
                    ExpectedCTC = table.Column<string>(type: "text", nullable: false),
                    NoticePeriod = table.Column<string>(type: "text", nullable: false),
                    HasOfferLetter = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateProfiles", x => x.CandidateID);
                });

            migrationBuilder.CreateTable(
                name: "OfferDetails",
                columns: table => new
                {
                    OfferId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CandidateID = table.Column<string>(type: "text", nullable: false),
                    JobID = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OfferedCTC = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferDetails", x => x.OfferId);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<string>(type: "text", nullable: false),
                    ProjectName = table.Column<string>(type: "text", nullable: false),
                    ProjectDetails = table.Column<string>(type: "text", nullable: false),
                    ProjectManager = table.Column<string>(type: "text", nullable: false),
                    AccountID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "OpenPositions",
                columns: table => new
                {
                    JobId = table.Column<long>(type: "bigint", nullable: false),
                    JobTitle = table.Column<string>(type: "text", nullable: false),
                    AccountID = table.Column<string>(type: "text", nullable: true),
                    ProjectID = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_OpenPositions", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_OpenPositions_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "AccountID");
                    table.ForeignKey(
                        name: "FK_OpenPositions_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OpenPositions_AccountID",
                table: "OpenPositions",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_OpenPositions_JobTitle",
                table: "OpenPositions",
                column: "JobTitle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpenPositions_ProjectID",
                table: "OpenPositions",
                column: "ProjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateProfiles");

            migrationBuilder.DropTable(
                name: "OfferDetails");

            migrationBuilder.DropTable(
                name: "OpenPositions");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
