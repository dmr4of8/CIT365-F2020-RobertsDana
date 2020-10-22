﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class New_DataAnnotations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.AlterColumn<string>(
                    name: "Title",
                    table: "Movie",
                    maxLength: 60,
                    nullable: false,
                    oldClrType: typeof(string),
                    oldNullable: true);

                migrationBuilder.AlterColumn<string>(
                    name: "Rating",
                    table: "Movie",
                    maxLength: 5,
                    nullable: false,
                    oldClrType: typeof(string),
                    oldNullable: true);

                migrationBuilder.AlterColumn<string>(
                    name: "Genre",
                    table: "Movie",
                    maxLength: 30,
                    nullable: false,
                    oldClrType: typeof(string),
                    oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
