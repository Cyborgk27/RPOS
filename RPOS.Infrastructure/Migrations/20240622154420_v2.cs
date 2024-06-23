using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPOS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CategoryDescription",
                table: "Categories",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurants",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditCreateDate",
                table: "Restaurants",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AuditCreateUser",
                table: "Restaurants",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditDeleteDate",
                table: "Restaurants",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditDeleteUser",
                table: "Restaurants",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditUpdateDate",
                table: "Restaurants",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditUpdateUser",
                table: "Restaurants",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditCreateDate",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AuditCreateUser",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditDeleteDate",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditDeleteUser",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditUpdateDate",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditUpdateUser",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditCreateDate",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AuditCreateUser",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditDeleteDate",
                table: "Categories",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditDeleteUser",
                table: "Categories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditUpdateDate",
                table: "Categories",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditUpdateUser",
                table: "Categories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditCreateDate",
                table: "Addresses",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AuditCreateUser",
                table: "Addresses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditDeleteDate",
                table: "Addresses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditDeleteUser",
                table: "Addresses",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AuditUpdateDate",
                table: "Addresses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditUpdateUser",
                table: "Addresses",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuditCreateDate",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "AuditCreateUser",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "AuditDeleteDate",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "AuditDeleteUser",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "AuditUpdateDate",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "AuditUpdateUser",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "AuditCreateDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuditCreateUser",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuditDeleteDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuditDeleteUser",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuditUpdateDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuditUpdateUser",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuditCreateDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AuditCreateUser",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AuditDeleteDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AuditDeleteUser",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AuditUpdateDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AuditUpdateUser",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AuditCreateDate",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AuditCreateUser",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AuditDeleteDate",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AuditDeleteUser",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AuditUpdateDate",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AuditUpdateUser",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "CategoryDescription");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurants",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Products",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "decimal(18,2)");
        }
    }
}
