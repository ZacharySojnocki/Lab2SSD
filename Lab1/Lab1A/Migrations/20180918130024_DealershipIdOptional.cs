using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Lab1A.Migrations
{
    public partial class DealershipIdOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DealershipID",
                table: "Car",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DealershipID",
                table: "Car",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
