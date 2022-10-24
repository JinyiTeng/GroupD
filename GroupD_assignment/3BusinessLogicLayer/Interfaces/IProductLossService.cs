using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IProductLossService
    {
        Task<ProductLossModel?> GetById(int ProductLossID);
        Task<List<ProductLossModel>> GetAll();

        Task<int> CreateProductLoss(ProductLossModel ProductLoss);
        Task UpdateProductLoss(ProductLossModel ProductLoss);
        Task DeleteProductLoss(int ProductLossID);
    }
}
