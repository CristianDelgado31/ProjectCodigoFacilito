﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectoCodigoFacilito.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnInReferenceId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "ReferenceIds",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "ReferenceIds");
        }
    }
}
