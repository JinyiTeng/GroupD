using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Stock
    {
        public int StockID { get; set; } // int
        public string ProductName { get; set; } // nvarchar(100)
        public int OrderAmount { get; set; } // int
        public decimal TotalOrderPrice { get; set; } // decimal

    }
}
