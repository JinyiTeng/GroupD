

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class StockService :  IStockService
    {
        private readonly IStockDal _StockDal;
        //private readonly IStockBalService _StockBalService;
        public StockService(IStockDal StockDal
        //ILoggingService loggingService,
        //IStockDal StockDal,
        //IAuditDal auditDal
       // IStockBalanceService balsvc
        ) 
        {
            _StockDal = StockDal;
            // _StockBalService = balsvc;
        }

        public async Task<StockModel?> GetById(int StockId)
        {           
            return _StockDal.GetById(StockId);
        }

        public async Task<List<StockModel>> GetAll()
        {            
            return _StockDal.GetAll();
        }

        public async Task<int> CreateStock(StockModel Stock)
        {
            //write validations here
            var newStockId = _StockDal.CreateStock(Stock);
            return newStockId;
        }

        public async Task UpdateStock(StockModel Stock)
        {
            //write validations here 
            _StockDal.UpdateStock(Stock);
        }

        public async Task DeleteStock(int StockId)
        {            
            try
            {
                //if(balservice.getBal(StockId) = 0)
                _StockDal.DeleteStock(StockId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Stock Id:{StockId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
