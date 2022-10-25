using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IProductLossDal
    {
        // Getters
        ProductLossModel? GetById(int ProductLossID);
        List<ProductLossModel> GetAll();

        // Actions
        int CreateProductLoss(ProductLossModel ProductLoss);
        void UpdateProductLoss(ProductLossModel ProductLoss);
        void DeleteProductLoss(int ProductLossId);
    }
}
