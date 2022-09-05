using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OperatorMonitor.Data.Migrations
{
    public partial class InitialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOperationLog",
                columns: table => new
                {
                    LogID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerHash = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    AccessLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessDirection = table.Column<int>(type: "int", nullable: false),
                    VerifyStatusCode = table.Column<int>(type: "int", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    LogTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOperationLog", x => x.LogID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOperationLog");
        }
    }
}
