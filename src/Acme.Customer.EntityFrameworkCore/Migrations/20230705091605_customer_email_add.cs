using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Customer.Migrations
{
    /// <inheritdoc />
    public partial class customeremailadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CustomersId",
                table: "CustomerEmails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEmails_CustomersId",
                table: "CustomerEmails",
                column: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEmails_Customers_CustomersId",
                table: "CustomerEmails",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEmails_Customers_CustomersId",
                table: "CustomerEmails");

            migrationBuilder.DropIndex(
                name: "IX_CustomerEmails_CustomersId",
                table: "CustomerEmails");

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "CustomerEmails");
        }
    }
}
