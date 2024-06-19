using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloApi.Migrations
{
    public partial class createdslidertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "sliders",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "SoftDelete", "Title" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ssssss", "nsamw", false, "title" });

            migrationBuilder.InsertData(
                table: "sliders",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "SoftDelete", "Title" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ssssss2", "nsamw2", false, "title2" });

            migrationBuilder.InsertData(
                table: "sliders",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "SoftDelete", "Title" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ssssss3", "nsamw3", false, "title3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sliders");
        }
    }
}
