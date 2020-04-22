﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceApp.Migrations.SqlServerMigrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "ID", "Description", "Duration", "Price", "ServiceType" },
                values: new object[,]
                {
                    { 1, "Initial Evaluation where physical therapist will spend time with you to learn about your condition, your previous level of function, and how your condition is affecting your life.", "1 hour", 100.00m, 0 },
                    { 2, "Follow up evaluation.", "30 minutes", 50.00m, 1 },
                    { 3, "Lower back stuff here.", "30 minutes", 75.00m, 3 },
                    { 4, "Neck stuff here.", "45 minutes", 100.00m, 2 },
                    { 5, "Upper back stuff here.", "30 minutes", 75.00m, 4 },
                    { 6, "Package deal lower back stuff here.", "1 hour 30 minutes", 100.00m, 8 },
                    { 7, "Package deal neck stuff here.", "1 hour 30 minutes", 125.00m, 7 },
                    { 8, "Package deal lower back stuff here.", "1 hour 30 minutes", 100.00m, 9 },
                    { 9, "60 minute massage description here.", "60 minutes", 80.00m, 6 },
                    { 10, "60 minute massage description here.", "30 minutes", 45.00m, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");
        }
    }
}
