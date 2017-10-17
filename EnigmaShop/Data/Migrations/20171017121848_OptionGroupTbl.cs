﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EnigmaShop.Data.Migrations
{
    public partial class OptionGroupTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OptionGroup",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "OptionGroup");
        }
    }
}
