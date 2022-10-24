using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class ProductLossModel
    {
        public int ProductLossID { get; set; } // int
        public string ProductName { get; set; } // nvarchar(100)
        public string Reason { get; set; } // nvarchar(500)
        public int LossAmount { get; set; } // int

    }

}
