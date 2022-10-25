using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }

    }

    public static class CustomerDtoMapExtensions
    {
        public static CustomerDto ToCustomerDto(this CustomerModel src)
        {
            var dst = new CustomerDto();
            dst.CustomerId = src.CustomerId;
            dst.CustomerFirstName = src.CustomerFirstName;
            dst.CustomerLastName = src.CustomerLastName;
            dst.CustomerPhone = src.CustomerPhone;
            dst.CustomerAddress = src.CustomerAddress;
            return dst;
        }

        public static CustomerModel ToCustomerModel(this CustomerDto src)
        {
            var dst = new CustomerModel();
            dst.CustomerId = src.CustomerId;
            dst.CustomerFirstName = src.CustomerFirstName;
            dst.CustomerLastName= src.CustomerLastName;
            dst.CustomerPhone = src.CustomerPhone;
            dst.CustomerAddress = src.CustomerAddress;
            return dst;
        }
    }
}
