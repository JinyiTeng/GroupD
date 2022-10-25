using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } // int
        public string CustomerFirstName { get; set; } // nvarchar(400)

        public string CustomerLastName { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerAddress { get; set; }

    }
}
