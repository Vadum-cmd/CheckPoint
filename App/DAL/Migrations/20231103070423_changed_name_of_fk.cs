// <copyright file="20231103070423_changed_name_of_fk.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

#nullable disable

namespace DAL.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    /// <inheritdoc />
    public partial class Changed_name_of_fk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Action_Product_ProductId1",
                table: "Action");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleStatistic_Product_ProductId1",
                table: "SaleStatistic");

            migrationBuilder.RenameColumn(
                name: "ProductId1",
                table: "SaleStatistic",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleStatistic_ProductId1",
                table: "SaleStatistic",
                newName: "IX_SaleStatistic_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductId1",
                table: "Action",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Action_ProductId1",
                table: "Action",
                newName: "IX_Action_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Action_Product_ProductId",
                table: "Action",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleStatistic_Product_ProductId",
                table: "SaleStatistic",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Action_Product_ProductId",
                table: "Action");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleStatistic_Product_ProductId",
                table: "SaleStatistic");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "SaleStatistic",
                newName: "ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_SaleStatistic_ProductId",
                table: "SaleStatistic",
                newName: "IX_SaleStatistic_ProductId1");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Action",
                newName: "ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_Action_ProductId",
                table: "Action",
                newName: "IX_Action_ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Action_Product_ProductId1",
                table: "Action",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleStatistic_Product_ProductId1",
                table: "SaleStatistic",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "Id");
        }
    }
}
