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
    public class StaffDal : IStaffDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public StaffDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<StaffModel> GetAll()
        {
            var result = _db.Staffs.ToList();

            var returnObject = new List<StaffModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToStaffModel());
            }

            return returnObject;
        }

        public StaffModel? GetById(int StaffId)
        {
            var result = _db.Staffs.SingleOrDefault(x => x.StaffId == StaffId);
            return result?.ToStaffModel();
        }


        public int CreateStaff(StaffModel Staff)
        {
            var newStaff = Staff.ToStaff();
            _db.Staffs.Add(newStaff);
            _db.SaveChanges();
            return newStaff.StaffId;
        }


        public void UpdateStaff(StaffModel Staff)
        {
            var existingStaff = _db.Staffs
                .SingleOrDefault(x => x.StaffId == Staff.StaffId);

            if (existingStaff == null)
            {
                throw new ApplicationException($"Staff {Staff.StaffId} does not exist.");
            }
            Staff.ToStaff(existingStaff);

            _db.Update(existingStaff);
            _db.SaveChanges();
        }

        public void DeleteStaff(int StaffId)
        {
            var efModel = _db.Staffs.Find(StaffId);
            _db.Staffs.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
