using Microsoft.EntityFrameworkCore.Migrations;

namespace DebitOrdersApi.Migrations
{
    public partial class BankBranchCodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creditors_Banks_BankId",
                table: "Creditors");

            migrationBuilder.DropForeignKey(
                name: "FK_Creditors_Branches_BranchId",
                table: "Creditors");

            migrationBuilder.DropIndex(
                name: "IX_Creditors_BankId",
                table: "Creditors");

            migrationBuilder.DropIndex(
                name: "IX_Creditors_BranchId",
                table: "Creditors");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Creditors",
                newName: "BranchCode");

            migrationBuilder.RenameColumn(
                name: "BankId",
                table: "Creditors",
                newName: "BankCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BranchCode",
                table: "Creditors",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "BankCode",
                table: "Creditors",
                newName: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Creditors_BankId",
                table: "Creditors",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Creditors_BranchId",
                table: "Creditors",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Creditors_Banks_BankId",
                table: "Creditors",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Creditors_Branches_BranchId",
                table: "Creditors",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
