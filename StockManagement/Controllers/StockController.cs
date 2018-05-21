using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using StockManagement.Models.DatabaseContext;
using StockManagement.Models.EntityModels;
using StockManagement.Models.ViewModels;

namespace StockManagement.Controllers
{
    public class StockController : Controller
    {
        StockDbContext db=new StockDbContext();
        [HttpGet]
        // GET: Stock
        public ActionResult StockIn()
        {
            var model=new StockInCreateVM();
            model.Categories = db.Categories.ToList();
            ViewBag.ProductDropDown = new SelectListItem[] {new SelectListItem() {Value = "", Text = "Select Item"}};
            return View(model);
        }
        [HttpPost]
        public ActionResult StockIn(StockInCreateVM stockInCreate)
        {
            if (ModelState.IsValid)
            {
                StockIn stock = Mapper.Map<StockIn>(stockInCreate);
                
                db.StockIns.Add(stock);
                if (db.SaveChanges() > 0)
                {
                    ViewBag.Message = "Data Has been saved Successfully";
                }
                return RedirectToAction("StockIn");

            }
            return View();
        }
    }
}