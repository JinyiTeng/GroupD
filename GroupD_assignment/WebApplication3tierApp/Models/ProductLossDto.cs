using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class ProductLossDto
    {

        public int ProductLossID { get; set; } // int
        public string ProductName { get; set; } // nvarchar(100)
        public string Reason { get; set; } // nvarchar(500)
        public int LossAmount { get; set; } // int

    }

    public static class ProductLossDtoMapExtensions
    {
        public static ProductLossDto ToProductLossDto(this ProductLossModel src)
        {
            var dst = new ProductLossDto();
            dst.ProductLossID = src.ProductLossID;
            dst.ProductName = src.ProductName;            
            dst.Reason = src.Reason;   
            dst.LossAmount = src.LossAmount;
            return dst;
        }

        public static ProductLossModel ToProductLossModel(this ProductLossDto src)
        {
            var dst = new ProductLossModel();
            dst.ProductLossID = src.ProductLossID;
            dst.ProductName = src.ProductName;
            dst.Reason = src.Reason;
            dst.LossAmount = src.LossAmount;
            return dst;
        }
    }
}
