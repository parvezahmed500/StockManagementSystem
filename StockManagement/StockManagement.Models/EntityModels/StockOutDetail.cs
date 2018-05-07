using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models.EntityModels
{
    class StockOutDetail
    {
        public int Id { get; set; }
        public int StockOutId { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public StockOut StockOut { get; set; }
        public Product Product { get; set; }
    }
}
