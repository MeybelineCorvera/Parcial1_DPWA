using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial1_DPWA.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Faculties",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CantidadCarreras",
                table: "Faculties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Faculties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Edited",
                table: "Faculties",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditedBy",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadCarreras",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "Edited",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "EditedBy",
                table: "Faculties");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
