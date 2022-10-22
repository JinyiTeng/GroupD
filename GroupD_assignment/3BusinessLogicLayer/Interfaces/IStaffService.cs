using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IStaffService
    {
        Task<StaffModel?> GetById(int StaffId);
        Task<List<StaffModel>> GetAll();

        Task<int> CreateStaff(StaffModel Staff);
        Task UpdateStaff(StaffModel Staff);
        Task DeleteStaff(int StaffId);
    }
}
