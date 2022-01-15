using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore2._1UpgradeTo5._0WebApp.Migrations
{
    public partial class EFCore5_InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankStatusLogs_ProcessBank_BankTransactionId",
                table: "BankStatusLogs");

            migrationBuilder.DropTable(
                name: "ProcessBank");

            migrationBuilder.AddForeignKey(
                name: "FK_BankStatusLogs_Transactions_BankTransactionId",
                table: "BankStatusLogs",
                column: "BankTransactionId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankStatusLogs_Transactions_BankTransactionId",
                table: "BankStatusLogs");

            migrationBuilder.CreateTable(
                name: "ProcessBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessBank", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BankStatusLogs_ProcessBank_BankTransactionId",
                table: "BankStatusLogs",
                column: "BankTransactionId",
                principalTable: "ProcessBank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
