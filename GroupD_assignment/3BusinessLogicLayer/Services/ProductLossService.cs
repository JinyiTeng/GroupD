

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class ProductLossService :  IProductLossService
    {
        private readonly IProductLossDal _ProductLossDal;
        //private readonly IProductLossBalService _ProductLossBalService;
        public ProductLossService(IProductLossDal ProductLossDal
        //ILoggingService loggingService,
        //IProductLossDal ProductLossDal,
        //IAuditDal auditDal
       // IProductLossBalanceService balsvc
        ) 
        {
            _ProductLossDal = ProductLossDal;
            // _ProductLossBalService = balsvc;
        }

        public async Task<ProductLossModel?> GetById(int ProductLossId)
        {           
            return _ProductLossDal.GetById(ProductLossId);
        }

        public async Task<List<ProductLossModel>> GetAll()
        {            
            return _ProductLossDal.GetAll();
        }

        public async Task<int> CreateProductLoss(ProductLossModel ProductLoss)
        {
            //write validations here
            var newProductLossId = _ProductLossDal.CreateProductLoss(ProductLoss);
            return newProductLossId;
        }

        public async Task UpdateProductLoss(ProductLossModel ProductLoss)
        {
            //write validations here 
            _ProductLossDal.UpdateProductLoss(ProductLoss);
        }

        public async Task DeleteProductLoss(int ProductLossId)
        {            
            try
            {
                //if(balservice.getBal(ProductLossId) = 0)
                _ProductLossDal.DeleteProductLoss(ProductLossId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete ProductLoss Id:{ProductLossId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
