using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DomainModels.Migrations
{
    public partial class inti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: true),
                    DeliveryStatus = table.Column<int>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DeliveryDate", "DeliveryStatus", "IsDeleted", "ProductDescription" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "Large Pizza with CocaCola" },
                    { 2, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "Large Pizza with CocaCola" },
                    { 3, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "Large Pizza with CocaCola" },
                    { 4, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "Large Pizza with CocaCola" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
