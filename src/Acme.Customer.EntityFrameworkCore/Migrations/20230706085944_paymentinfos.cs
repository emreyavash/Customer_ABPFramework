using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Customer.Migrations
{
    /// <inheritdoc />
    public partial class paymentinfos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPayments_CustomerPaymentInfos_Id",
                table: "CustomerPayments");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomersId",
                table: "CustomerPaymentInfos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentId",
                table: "CustomerPaymentInfos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentInfos_CustomersId",
                table: "CustomerPaymentInfos",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentInfos_PaymentId",
                table: "CustomerPaymentInfos",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPaymentInfos_CustomerPayments_PaymentId",
                table: "CustomerPaymentInfos",
                column: "PaymentId",
                principalTable: "CustomerPayments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPaymentInfos_Customers_CustomersId",
                table: "CustomerPaymentInfos",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPaymentInfos_CustomerPayments_PaymentId",
                table: "CustomerPaymentInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPaymentInfos_Customers_CustomersId",
                table: "CustomerPaymentInfos");

            migrationBuilder.DropIndex(
                name: "IX_CustomerPaymentInfos_CustomersId",
                table: "CustomerPaymentInfos");

            migrationBuilder.DropIndex(
                name: "IX_CustomerPaymentInfos_PaymentId",
                table: "CustomerPaymentInfos");

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "CustomerPaymentInfos");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "CustomerPaymentInfos");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPayments_CustomerPaymentInfos_Id",
                table: "CustomerPayments",
                column: "Id",
                principalTable: "CustomerPaymentInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
