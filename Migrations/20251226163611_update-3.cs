using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Nusantara.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instalments_Loans_LoanId",
                table: "Instalments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanMaster",
                table: "LoanMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instalments",
                table: "Instalments");

            migrationBuilder.RenameTable(
                name: "LoanMaster",
                newName: "LoanMasters");

            migrationBuilder.RenameTable(
                name: "Instalments",
                newName: "Installments");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Savings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "SavingMasters",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "maxAmount",
                table: "SavingMasters",
                newName: "MaxAmount");

            migrationBuilder.RenameColumn(
                name: "interest",
                table: "SavingMasters",
                newName: "Interest");

            migrationBuilder.RenameColumn(
                name: "fine",
                table: "SavingMasters",
                newName: "Fine");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "SavingMasters",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SavingMasters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Members",
                newName: "level");

            migrationBuilder.RenameColumn(
                name: "KkpPath",
                table: "Loans",
                newName: "KkPath");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Installments",
                newName: "amount");

            migrationBuilder.RenameIndex(
                name: "IX_Instalments_LoanId",
                table: "Installments",
                newName: "IX_Installments_LoanId");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Inhouses",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanMasters",
                table: "LoanMasters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Installments",
                table: "Installments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BalanceHistories",
                columns: table => new
                {
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MemberCode = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TransactionName = table.Column<string>(type: "text", nullable: false),
                    Flow = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Installments_Loans_LoanId",
                table: "Installments",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Installments_Loans_LoanId",
                table: "Installments");

            migrationBuilder.DropTable(
                name: "BalanceHistories");

            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanMasters",
                table: "LoanMasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Installments",
                table: "Installments");

            migrationBuilder.RenameTable(
                name: "LoanMasters",
                newName: "LoanMaster");

            migrationBuilder.RenameTable(
                name: "Installments",
                newName: "Instalments");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Savings",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SavingMasters",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MaxAmount",
                table: "SavingMasters",
                newName: "maxAmount");

            migrationBuilder.RenameColumn(
                name: "Interest",
                table: "SavingMasters",
                newName: "interest");

            migrationBuilder.RenameColumn(
                name: "Fine",
                table: "SavingMasters",
                newName: "fine");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "SavingMasters",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SavingMasters",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "level",
                table: "Members",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "KkPath",
                table: "Loans",
                newName: "KkpPath");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Instalments",
                newName: "Amount");

            migrationBuilder.RenameIndex(
                name: "IX_Installments_LoanId",
                table: "Instalments",
                newName: "IX_Instalments_LoanId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Remarks",
                table: "Inhouses",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanMaster",
                table: "LoanMaster",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instalments",
                table: "Instalments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instalments_Loans_LoanId",
                table: "Instalments",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
