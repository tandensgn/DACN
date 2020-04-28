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
        qlbdtDbEntities db = new qlbdtDbEntities();
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult AboutUs()
        {

            return View();
        }

        [ChildActionOnly]
        public ActionResult CategoriesHeader()
        {
            
            var categories = from i in db.categories
                             select new CategoriesList()
                             {
                                 cateID = i.cate_id,
                                 cateSeries = i.cate_series
                             };
            return PartialView("header", categories);
        }
        public ActionResult CategoriesFooter()
        {
            var categories = from i in db.categories
                             select new CategoriesList()
                             {
                                 cateID = i.cate_id,
                                 cateSeries = i.cate_series
                             };
            return PartialView("footer", categories);
        }
        public ActionResult Product()
        {
            var products = from i in db.products
                           select new ShowProduct()
                           {
                               productID = i.prod_id,
                               productName = i.prod_name,
                               productPrice = i.prod_price,
                               productImage = i.prod_image,
                               productWarranty = i.prod_warranty,
                               productAccessories = i.prod_accessories,
                               productCondition = i.prod_condition,
                               productPromotion = i.prod_promotion,
                               productStatus = i.prod_status,
                               productDescription = i.prod_description,
                               productFeatured = i.prod_featured,
                               productScreen = i.prod_screen,
                               productOs = i.prod_os,
                               productCamf = i.prod_camf,
                               productCamr = i.prod_camr,
                               productCpu = i.prod_cpu,
                               productRam = i.prod_ram,
                               productImemory = i.prod_Imemory,
                               productEmemory = i.prod_Ememory,
                               productSim = i.prod_sim,
                               productPin = i.prod_pin,
                               cateID = i.cate_id
                           };
            return View(products);
        }
        public ActionResult ProductDetail(int productID)
        {
            var productDetail = from i in db.products
                                where i.prod_id == productID
                                select new ShowProduct()
                           {
                               productID = i.prod_id,
                               productName = i.prod_name,
                               productPrice = i.prod_price,
                               productImage = i.prod_image,
                               productWarranty = i.prod_warranty,
                               productAccessories = i.prod_accessories,
                               productCondition = i.prod_condition,
                               productPromotion = i.prod_promotion,
                               productStatus = i.prod_status,
                               productDescription = i.prod_description,
                               productFeatured = i.prod_featured,
                               productScreen = i.prod_screen,
                               productOs = i.prod_os,
                               productCamf = i.prod_camf,
                               productCamr = i.prod_camr,
                               productCpu = i.prod_cpu,
                               productRam = i.prod_ram,
                               productImemory = i.prod_Imemory,
                               productEmemory = i.prod_Ememory,
                               productSim = i.prod_sim,
                               productPin = i.prod_pin,
                               cateID = i.cate_id
                           };
            return View(productDetail);
        }

    }
}