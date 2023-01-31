using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenPositionService.V1.Migrations
{
    /// <inheritdoc />
    public partial class WithAccountTeamName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "JobId",
                table: "OpenPositions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValue: 20230130161955L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "JobId",
                table: "OpenPositions",
                type: "bigint",
                nullable: false,
                defaultValue: 20230130161955L,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
