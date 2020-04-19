using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DACN_SalePhone.Models;

namespace DACN_SalePhone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }


        [ChildActionOnly]
        public ActionResult Header()
        {
            qlbdtDbEntities db = new qlbdtDbEntities();
            var categories = from i in db.categories
                             select new CategoriesList()
                             {
                                 cateID = i.cate_id,
                                 cateSeries = i.cate_series
                             };
            return PartialView("header", categories);
        }
    }
}