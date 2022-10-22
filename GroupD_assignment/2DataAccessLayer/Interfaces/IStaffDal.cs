using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IStaffDal
    {
        // Getters
        StaffModel? GetById(int StaffId);
        List<StaffModel> GetAll();

        // Actions
        int CreateStaff(StaffModel Staff);
        void UpdateStaff(StaffModel Staff);
        void DeleteStaff(int StaffId);
    }
}
