using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;

namespace StockManagement.Models.ViewModels
{
    public class StockInCreateVM
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime StockDate { get; set; }

        public string Description { get; set; }
        public List<Category> Categories { get; set; } 
        public List<StockInDetail> StockInDetails { get; set; }
    }
}
