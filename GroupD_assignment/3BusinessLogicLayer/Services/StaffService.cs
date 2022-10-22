

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class StaffService :  IStaffService
    {
        private readonly IStaffDal _StaffDal;
        //private readonly IStaffBalService _StaffBalService;
        public StaffService(IStaffDal StaffDal
        //ILoggingService loggingService,
        //IStaffDal StaffDal,
        //IAuditDal auditDal
       // IStaffBalanceService balsvc
        ) 
        {
            _StaffDal = StaffDal;
            // _StaffBalService = balsvc;
        }

        public async Task<StaffModel?> GetById(int StaffId)
        {           
            return _StaffDal.GetById(StaffId);
        }

        public async Task<List<StaffModel>> GetAll()
        {            
            return _StaffDal.GetAll();
        }

        public async Task<int> CreateStaff(StaffModel Staff)
        {
            //write validations here
            var newStaffId = _StaffDal.CreateStaff(Staff);
            return newStaffId;
        }

        public async Task UpdateStaff(StaffModel Staff)
        {
            //write validations here 
            _StaffDal.UpdateStaff(Staff);
        }

        public async Task DeleteStaff(int StaffId)
        {            
            try
            {
                //if(balservice.getBal(StaffId) = 0)
                _StaffDal.DeleteStaff(StaffId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Staff Id:{StaffId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
