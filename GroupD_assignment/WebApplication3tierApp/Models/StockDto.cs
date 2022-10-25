using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class StockDto
    {
        public int StockID { get; set; } // int
        public string ProductName { get; set; } // nvarchar(100)
        public int OrderAmount { get; set; } // int
        public decimal TotalOrderPrice { get; set; } // decimal

    }

    public static class StockDtoMapExtensions
    {
        public static StockDto ToStockDto(this StockModel src)
        {
            var dst = new StockDto();
            dst.StockID = src.StockID;
            dst.ProductName = src.ProductName;            
            dst.OrderAmount = src.OrderAmount;   
            dst.TotalOrderPrice = src.TotalOrderPrice;
            return dst;
        }

        public static StockModel ToStockModel(this StockDto src)
        {
            var dst = new StockModel();
            dst.StockID = src.StockID;
            dst.ProductName = src.ProductName;
            dst.OrderAmount = src.OrderAmount;
            dst.TotalOrderPrice = src.TotalOrderPrice;
            return dst;
        }
    }
}
