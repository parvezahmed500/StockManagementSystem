using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagement.Models.EntityModels;

namespace StockManagement.Models.EntityModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}