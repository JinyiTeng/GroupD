using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IStockService
    {
        Task<StockModel?> GetById(int StockID);
        Task<List<StockModel>> GetAll();

        Task<int> CreateStock(StockModel Stock);
        Task UpdateStock(StockModel Stock);
        Task DeleteStock(int StockID);
    }
}
