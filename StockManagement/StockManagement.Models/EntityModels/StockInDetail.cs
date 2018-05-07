using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagement.Models.EntityModels
{
    public class StockInDetail
    {
        public int Id { get; set; }
        public int StockInId { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public StockIn StockIn { get; set; }
        public Product Product { get; set; }
    }
}