using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class StockModel
    {
        public int StockID { get; set; } // int
        public string ProductName { get; set; } // nvarchar(100)
        public int OrderAmount { get; set; } // int
        public decimal TotalOrderPrice { get; set; } // decimal

    }

}
