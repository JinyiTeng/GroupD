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
    public class ProductLossDal : IProductLossDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public ProductLossDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<ProductLossModel> GetAll()
        {
            var result = _db.ProductLoss.ToList();

            var returnObject = new List<ProductLossModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToProductLossModel());
            }

            return returnObject;
        }

        public ProductLossModel? GetById(int ProductLossId)
        {
            var result = _db.ProductLoss.SingleOrDefault(x => x.ProductLossID == ProductLossId);
            return result?.ToProductLossModel();
        }


        public int CreateProductLoss(ProductLossModel ProductLoss)
        {
            var newProductLoss = ProductLoss.ToProductLoss();
            _db.ProductLoss.Add(newProductLoss);
            _db.SaveChanges();
            return newProductLoss.ProductLossID;
        }


        public void UpdateProductLoss(ProductLossModel ProductLoss)
        {
            var existingProductLoss = _db.ProductLoss
                .SingleOrDefault(x => x.ProductLossID == ProductLoss.ProductLossID);

            if (existingProductLoss == null)
            {
                throw new ApplicationException($"ProductLoss {ProductLoss.ProductLossID} does not exist.");
            }
            ProductLoss.ToProductLoss(existingProductLoss);

            _db.Update(existingProductLoss);
            _db.SaveChanges();
        }

        public void DeleteProductLoss(int ProductLossId)
        {
            var efModel = _db.ProductLoss.Find(ProductLossId);
            _db.ProductLoss.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
