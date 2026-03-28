using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurrencyChange.Api.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExchangeRateResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documentation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TermsOfUse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeLastUpdateUnix = table.Column<long>(type: "bigint", nullable: false),
                    TimeLastUpdateUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeNextUpdateUnix = table.Column<long>(type: "bigint", nullable: false),
                    TimeNextUpdateUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConversionRates = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRateResponses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExchangeRateResponses");
        }
    }
}
