using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class StockMapExtensions
    {
        public static StockModel ToStockModel(this Stock src)
        {
            var dst = new StockModel();

            dst.StockID = src.StockID;
            dst.ProductName = src.ProductName;
            dst.OrderAmount = src.OrderAmount;
            dst.TotalOrderPrice = src.TotalOrderPrice;

            return dst;
        }

        public static Stock ToStock(this StockModel src, Stock dst = null)
        {
            if (dst == null)
            {
                dst = new Stock();
            }

            dst.StockID = src.StockID;
            dst.ProductName = src.ProductName;
            dst.OrderAmount = src.OrderAmount;
            dst.TotalOrderPrice = src.TotalOrderPrice;

            return dst;
        }
    }
}
