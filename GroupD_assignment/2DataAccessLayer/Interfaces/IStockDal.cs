using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IStockDal
    {
        // Getters
        StockModel? GetById(int StockID);
        List<StockModel> GetAll();

        // Actions
        int CreateStock(StockModel Stock);
        void UpdateStock(StockModel Stock);
        void DeleteStock(int StockId);
    }
}
