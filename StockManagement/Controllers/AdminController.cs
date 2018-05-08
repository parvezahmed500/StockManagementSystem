using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockManagement.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string uname, string psw)
        {
            if (uname == "admin" && psw == "admin")
            {
                return View("Admin");
            }
            return View();
        }
    }
}