using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Customer.Migrations
{
    /// <inheritdoc />
    public partial class entityrelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerEmails");

            migrationBuilder.DropColumn(
                name: "EmailTypeId",
                table: "CustomerEmails");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerIdId",
                table: "CustomerEmails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEmails_CustomerIdId",
                table: "CustomerEmails",
                column: "CustomerIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEmails_Customers_CustomerIdId",
                table: "CustomerEmails",
                column: "CustomerIdId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailTypes_CustomerEmails_Id",
                table: "EmailTypes",
                column: "Id",
                principalTable: "CustomerEmails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEmails_Customers_CustomerIdId",
                table: "CustomerEmails");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailTypes_CustomerEmails_Id",
                table: "EmailTypes");

            migrationBuilder.DropIndex(
                name: "IX_CustomerEmails_CustomerIdId",
                table: "CustomerEmails");

            migrationBuilder.DropColumn(
                name: "CustomerIdId",
                table: "CustomerEmails");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerEmails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmailTypeId",
                table: "CustomerEmails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
