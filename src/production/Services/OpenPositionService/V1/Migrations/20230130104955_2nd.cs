using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenPositionService.V1.Migrations
{
    /// <inheritdoc />
    public partial class _2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OpenPositions",
                table: "OpenPositions");

            migrationBuilder.DropIndex(
                name: "IX_OpenPositions_JobId",
                table: "OpenPositions");

            migrationBuilder.AlterColumn<long>(
                name: "JobId",
                table: "OpenPositions",
                type: "bigint",
                nullable: false,
                defaultValue: 20230130161955L,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "OpenPositions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "OpenPositions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpenPositions",
                table: "OpenPositions",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenPositions_JobTitle",
                table: "OpenPositions",
                column: "JobTitle",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OpenPositions",
                table: "OpenPositions");

            migrationBuilder.DropIndex(
                name: "IX_OpenPositions_JobTitle",
                table: "OpenPositions");

            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "OpenPositions");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "OpenPositions");

            migrationBuilder.AlterColumn<long>(
                name: "JobId",
                table: "OpenPositions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValue: 20230130161955L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpenPositions",
                table: "OpenPositions",
                column: "JobTitle");

            migrationBuilder.CreateIndex(
                name: "IX_OpenPositions_JobId",
                table: "OpenPositions",
                column: "JobId",
                unique: true);
        }
    }
}
