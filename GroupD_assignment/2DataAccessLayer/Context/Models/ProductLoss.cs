using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class ProductLoss
    {
        public int ProductLossID { get; set; } // int
        public string ProductName { get; set; } // nvarchar(100)
        public string Reason { get; set; } // nvarchar(500)
        public int LossAmount { get; set; } // int

    }
}
