using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagement.Models.EntityModels;

namespace StockManagement.Models.EntityModels
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Product> ProductList { get; set; }
    }
}