using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; } // int
        public string CustomerFirstName { get; set; } // nvarchar(400)

        public string CustomerLastName { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerAddress { get; set; }

    }

}
