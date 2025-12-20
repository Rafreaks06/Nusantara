using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Nusantara.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AdminFee",
                table: "Savings",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedOn",
                table: "Savings",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Savings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DueDate",
                table: "Savings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Savings",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KkPath",
                table: "Savings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KtpPath",
                table: "Savings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SavingId",
                table: "Savings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SlipGajiPath",
                table: "Savings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Savings",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "WithdrawDate",
                table: "Savings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Exchanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MemberId = table.Column<int>(type: "integer", nullable: false),
                    ExchangeId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    AmountExchanged = table.Column<decimal>(type: "numeric", nullable: false),
                    Fee = table.Column<decimal>(type: "numeric", nullable: false),
                    Rate = table.Column<decimal>(type: "numeric", nullable: false),
                    ExchangeDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TotalAmountExchanged = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exchanges_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exchanges_MemberId",
                table: "Exchanges",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exchanges");

            migrationBuilder.DropColumn(
                name: "AdminFee",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "ApprovedOn",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "KkPath",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "KtpPath",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "SavingId",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "SlipGajiPath",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "WithdrawDate",
                table: "Savings");
        }
    }
}
