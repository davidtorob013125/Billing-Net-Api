using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Billing.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Employee_EmployId1",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "EmployId1",
                table: "Invoices",
                newName: "EmployeeId1");

            migrationBuilder.RenameColumn(
                name: "EmployId",
                table: "Invoices",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_EmployId1",
                table: "Invoices",
                newName: "IX_Invoices_EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Employee_EmployeeId1",
                table: "Invoices",
                column: "EmployeeId1",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Employee_EmployeeId1",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "EmployeeId1",
                table: "Invoices",
                newName: "EmployId1");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Invoices",
                newName: "EmployId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_EmployeeId1",
                table: "Invoices",
                newName: "IX_Invoices_EmployId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Employee_EmployId1",
                table: "Invoices",
                column: "EmployId1",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
