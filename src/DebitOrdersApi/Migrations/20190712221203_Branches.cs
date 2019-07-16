using Microsoft.EntityFrameworkCore.Migrations;

namespace DebitOrdersApi.Migrations
{
    public partial class Branches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Banks_BankId",
                table: "MyProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Branches");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_BankId",
                table: "Branches",
                newName: "IX_Branches_BankId");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Creditors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branches",
                table: "Branches",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Creditors_BranchId",
                table: "Creditors",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Banks_BankId",
                table: "Branches",
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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Banks_BankId",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Creditors_Branches_BranchId",
                table: "Creditors");

            migrationBuilder.DropIndex(
                name: "IX_Creditors_BranchId",
                table: "Creditors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branches",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Creditors");

            migrationBuilder.RenameTable(
                name: "Branches",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_Branches_BankId",
                table: "MyProperty",
                newName: "IX_MyProperty_BankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Banks_BankId",
                table: "MyProperty",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
