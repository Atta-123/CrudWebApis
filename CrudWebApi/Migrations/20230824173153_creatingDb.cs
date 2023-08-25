using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudWebApi.Migrations
{
    public partial class creatingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customerTypes",
                columns: table => new
                {
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerTypes", x => x.CustomerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customers_customerTypes_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "customerTypes",
                        principalColumn: "CustomerTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customerTypes",
                columns: new[] { "CustomerTypeId", "Name" },
                values: new object[] { 1, "SalaMan" });

            migrationBuilder.InsertData(
                table: "customerTypes",
                columns: new[] { "CustomerTypeId", "Name" },
                values: new object[] { 2, "Driver" });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "Address", "City", "CustomerTypeId", "Description", "LastDate", "Name", "State", "Zip" },
                values: new object[] { 1, "Pesh", "Pesh", 1, "Test", new DateTime(2023, 8, 24, 22, 31, 53, 78, DateTimeKind.Local).AddTicks(9734), "Atta", "Pak", "100" });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "Address", "City", "CustomerTypeId", "Description", "LastDate", "Name", "State", "Zip" },
                values: new object[] { 2, "Pesh", "Pesh", 2, "Test", new DateTime(2023, 8, 24, 22, 31, 53, 78, DateTimeKind.Local).AddTicks(9745), "Afridi", "Pak", "100" });

            migrationBuilder.CreateIndex(
                name: "IX_customers_CustomerTypeId",
                table: "customers",
                column: "CustomerTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "customerTypes");
        }
    }
}
