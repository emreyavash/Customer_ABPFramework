using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Customer.Migrations
{
    /// <inheritdoc />
    public partial class customerlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "Customers");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomersId",
                table: "CustomerPhoneNumbers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomersId",
                table: "CustomerAddresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPhoneNumbers_CustomersId",
                table: "CustomerPhoneNumbers",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomersId",
                table: "CustomerAddresses",
                column: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_Customers_CustomersId",
                table: "CustomerAddresses",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPhoneNumbers_Customers_CustomersId",
                table: "CustomerPhoneNumbers",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddresses_Customers_CustomersId",
                table: "CustomerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPhoneNumbers_Customers_CustomersId",
                table: "CustomerPhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerPhoneNumbers_CustomersId",
                table: "CustomerPhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddresses_CustomersId",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "CustomerPhoneNumbers");

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "CustomerAddresses");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
