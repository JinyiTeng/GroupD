using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class StaffDto
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffPhone { get; set; }
        public string StaffPosition { get; set; }
        public string StaffShift { get; set; }
    }

    public static class StaffDtoMapExtensions
    {
        public static StaffDto ToStaffDto(this StaffModel src)
        {
            var dst = new StaffDto();
            dst.StaffId = src.StaffId;
            dst.StaffName = src.StaffName;
            dst.StaffPhone = src.StaffPhone;
            dst.StaffPosition = src.StaffPosition;
            dst.StaffShift = src.StaffShift;
            return dst;
        }

        public static StaffModel ToStaffModel(this StaffDto src)
        {
            var dst = new StaffModel();
            dst.StaffId = src.StaffId;
            dst.StaffName = src.StaffName;
            dst.StaffPhone = src.StaffPhone;
            dst.StaffPosition = src.StaffPosition;
            dst.StaffShift = src.StaffShift;
            return dst;
        }
    }
}
