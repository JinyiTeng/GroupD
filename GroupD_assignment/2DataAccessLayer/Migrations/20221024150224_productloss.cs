using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2DataAccessLayer.Migrations
{
    public partial class productloss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "Staff");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "StaffId");

            migrationBuilder.CreateTable(
                name: "ProductLoss",
                columns: table => new
                {
                    ProductLossID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LossAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLoss", x => x.ProductLossID);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderAmount = table.Column<int>(type: "int", nullable: false),
                    TotalOrderPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductLoss");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.RenameTable(
                name: "Staff",
                newName: "Staffs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "StaffId");
        }
    }
}
