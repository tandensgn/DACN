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
        public ActionResult CC()
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
            var productInfo = from i in db.products
                           select new ProductsInfo()
                           {
                               productID = i.prod_id,
                               cateID = i.cate_id,
                               productName = i.prod_name,
                               productPrice = i.prod_price,
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
                           };
            var categoriesList = from i in db.categories
                             select new CategoriesList()
                             {
                                 cateID = i.cate_id,
                                 cateSeries = i.cate_series
                             };
            var imagesDetail = from i in db.imagesdetails
                             select new ImagesDetail()
                             {
                                 imgId = i.img_id,
                                 prodId = i.prod_id,
                                 imgLink = i.img_link
                             };

            var productInfoAll = new ProductsInfoAll()
            {
                productsInfo = productInfo.ToArray(),
                categoriesList = categoriesList.ToArray(),
                imagesDetail = imagesDetail.ToArray(),
            };

            return View(productInfoAll);
        }

        //public ActionResult PageProduct(int productID, int categoriesId)
        //{
        //    var productInfo = from i in db.products
        //                      where i.cate_id == categoriesId
        //                      select new ProductsInfo()
        //                      {
        //                          productID = i.prod_id,
        //                          cateID = i.cate_id,
        //                          productName = i.prod_name,
        //                          productPrice = i.prod_price,
        //                          productWarranty = i.prod_warranty,
        //                          productAccessories = i.prod_accessories,
        //                          productCondition = i.prod_condition,
        //                          productPromotion = i.prod_promotion,
        //                          productStatus = i.prod_status,
        //                          productDescription = i.prod_description,
        //                          productFeatured = i.prod_featured,
        //                          productScreen = i.prod_screen,
        //                          productOs = i.prod_os,
        //                          productCamf = i.prod_camf,
        //                          productCamr = i.prod_camr,
        //                          productCpu = i.prod_cpu,
        //                          productRam = i.prod_ram,
        //                          productImemory = i.prod_Imemory,
        //                          productEmemory = i.prod_Ememory,
        //                          productSim = i.prod_sim,
        //                          productPin = i.prod_pin,
        //                      };
        //    var categoriesList = from i in db.categories
        //                         select new CategoriesList()
        //                         {
        //                             cateID = i.cate_id,
        //                             cateSeries = i.cate_series
        //                         };
        //    var pageProducts = new PageProducts()
        //    {
        //        productsInfo = productInfo.ToArray(),
        //        categoriesList = categoriesList.ToArray(),
        //    };

        //    return View(pageProducts);
        //}
        

    }
}