using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class StaffMapExtensions
    {
        public static StaffModel ToStaffModel(this Staff src)
        {
            var dst = new StaffModel();

            dst.StaffId = src.StaffId;
            dst.StaffName = src.StaffName;
            dst.StaffPhone = src.StaffPhone;
            dst.StaffPosition = src.StaffPosition;
            dst.StaffShift = src.StaffShift;
            return dst;
        }

        public static Staff ToStaff(this StaffModel src, Staff dst = null)
        {
            if (dst == null)
            {
                dst = new Staff();
            }

            dst.StaffId = src.StaffId;
            dst.StaffName = src.StaffName;
            dst.StaffPhone = src.StaffPhone;
            dst.StaffPosition = src.StaffPosition;
            dst.StaffShift = src.StaffShift;
            return dst;
        }
    }
}
