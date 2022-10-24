using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class StockDal : IStockDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public StockDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<StockModel> GetAll()
        {
            var result = _db.Stock.ToList();

            var returnObject = new List<StockModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToStockModel());
            }

            return returnObject;
        }

        public StockModel? GetById(int StockId)
        {
            var result = _db.Stock.SingleOrDefault(x => x.StockID == StockId);
            return result?.ToStockModel();
        }


        public int CreateStock(StockModel Stock)
        {
            var newStock = Stock.ToStock();
            _db.Stock.Add(newStock);
            _db.SaveChanges();
            return newStock.StockID;
        }


        public void UpdateStock(StockModel Stock)
        {
            var existingStock = _db.Stock
                .SingleOrDefault(x => x.StockID == Stock.StockID);

            if (existingStock == null)
            {
                throw new ApplicationException($"Stock {Stock.StockID} does not exist.");
            }
            Stock.ToStock(existingStock);

            _db.Update(existingStock);
            _db.SaveChanges();
        }

        public void DeleteStock(int StockId)
        {
            var efModel = _db.Stock.Find(StockId);
            _db.Stock.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
