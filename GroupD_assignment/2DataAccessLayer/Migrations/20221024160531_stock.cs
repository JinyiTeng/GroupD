using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2DataAccessLayer.Migrations
{
    public partial class stock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Staffs");

        }

    
    }
}
