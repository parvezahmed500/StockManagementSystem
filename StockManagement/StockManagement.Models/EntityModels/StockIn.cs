using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagement.Models.EntityModels;

namespace StockManagement.Models.EntityModels
{
    public class StockIn
    {
        public int Id { get; set; }
        public DateTime StockDate { get; set; }

        public string Description { get; set; }
        public List<StockInDetail> StockInDetails { get; set; }
    }
}