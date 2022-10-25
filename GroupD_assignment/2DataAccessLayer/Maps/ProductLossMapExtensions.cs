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
    public static class ProductLossMapExtensions
    {
        public static ProductLossModel ToProductLossModel(this ProductLoss src)
        {
            var dst = new ProductLossModel();

            dst.ProductLossID = src.ProductLossID;
            dst.ProductName = src.ProductName;
            dst.Reason = src.Reason;
            dst.LossAmount = src.LossAmount;

            return dst;
        }

        public static ProductLoss ToProductLoss(this ProductLossModel src, ProductLoss dst = null)
        {
            if (dst == null)
            {
                dst = new ProductLoss();
            }

            dst.ProductLossID = src.ProductLossID;
            dst.ProductName = src.ProductName;
            dst.Reason = src.Reason;
            dst.LossAmount = src.LossAmount;

            return dst;
        }
    }
}
