using DACN_SalePhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DACN_SalePhone.Controllers
{
    public class ShoppingController : Controller
    {
        qlbdtDbEntities db = new qlbdtDbEntities();
        List<ShoppingCart> listOfShoppingCart = new List<ShoppingCart>();


        // Index //
        [HttpPost]
        public JsonResult Index(int itemID)
        {

            ShoppingCart objShoppingCart = new ShoppingCart();
            product objItem = db.products.Single(model => model.prod_id == itemID);
            if (Session["CartCounter"] != null)
            {
                listOfShoppingCart = Session["CartItem"] as List<ShoppingCart>;
            }
            if (listOfShoppingCart.Any(model => model.scproductID == itemID))
            {
                objShoppingCart = listOfShoppingCart.Single(model => model.scproductID == itemID);
                objShoppingCart.scQuantity = objShoppingCart.scQuantity + 1;
                objShoppingCart.scTotal = objShoppingCart.scQuantity * objShoppingCart.scUnitPrice;
            }
            else
            {
                objShoppingCart.scproductID = itemID;
                objShoppingCart.scIcon = objItem.prod_icon;
                objShoppingCart.scproductName = objItem.prod_name;
                objShoppingCart.scQuantity = 1;
                objShoppingCart.scTotal = objItem.prod_price;
                objShoppingCart.scUnitPrice = objItem.prod_price;
                listOfShoppingCart.Add(objShoppingCart);
            }

            Session["CartCounter"] = listOfShoppingCart.Count;
            Session["CartItem"] = listOfShoppingCart;

            return Json(new { Success = true, Counter = listOfShoppingCart.Count }, JsonRequestBehavior.AllowGet);
        }


        // Shopping Cart //
        public ActionResult ShoppingCart()
        {
            listOfShoppingCart = Session["CartItem"] as List<ShoppingCart>;
            return View(listOfShoppingCart);
        }
        // Add Order //
        [HttpPost]
        public ActionResult AddOrder()
        {
            int OrderId = 0;
            listOfShoppingCart = Session["CartItem"] as List<ShoppingCart>;
            order ordersObj = new order()
            {
                or_date = DateTime.Now,
                or_number = String.Format("{0:ddmmyyyyHHmmsss}", DateTime.Now)
            };
            db.orders.Add(ordersObj);
            db.SaveChanges();
            OrderId = ordersObj.or_id;

            foreach (var item in listOfShoppingCart)
            {
                orderdetail objOrderDetails = new orderdetail();
                objOrderDetails.ord_total = item.scTotal;
                objOrderDetails.prod_id = item.scproductID;
                objOrderDetails.or_id = OrderId;
                objOrderDetails.ord_qty = item.scQuantity;
                objOrderDetails.ord_price = item.scUnitPrice;
                db.orderdetails.Add(objOrderDetails);
                db.SaveChanges();

            }
            Session["CartItem"] = null;
            Session["CartCounter"] = null;
            return RedirectToAction("Index", "Home");
        }

        // Update Quantity and Total Price //
        //[HttpPost]
        //public JsonResult UpdateQuantity(int itemQty, string itemId)
        //{

        //    int proId = int.Parse(itemId);
        //    ShoppingCart objShoppingCart = new ShoppingCart();
        //    product objItem = db.products.Single(model => model.prod_id == proId);
        //    orderdetail objOrderDetails = new orderdetail();
        //    if (Session["CartCounter"] != null)
        //    {
        //        listOfShoppingCart = Session["CartItem"] as List<ShoppingCart>;
        //    }
        //    if (listOfShoppingCart.Any(model => model.scproductID == proId))
        //    {
        //        objShoppingCart = listOfShoppingCart.Single(model => model.scproductID == proId);
        //        objShoppingCart.scQuantity = itemQty;
        //        objShoppingCart.scTotal = objShoppingCart.scQuantity * objShoppingCart.scUnitPrice;
        //    }
        //    else
        //    {
        //        objShoppingCart.scproductID = proId;
        //        objShoppingCart.scIcon = objItem.prod_icon;
        //        objShoppingCart.scproductName = objItem.prod_name;
        //        objShoppingCart.scQuantity = itemQty;
        //        objShoppingCart.scTotal = objItem.prod_price;
        //        objShoppingCart.scUnitPrice = objItem.prod_price;
        //        listOfShoppingCart.Add(objShoppingCart);
        //    }


        //    Session["CartCounter"] = listOfShoppingCart.Count;
        //    Session["CartItem"] = listOfShoppingCart;

        //    return Json(new { Success = true, UpdateTotalItem = objShoppingCart.scTotal }, JsonRequestBehavior.AllowGet);
        //}


        //public ActionResult DeleteCartItem(int prodID)
        //{
        //    List<int> cart = (List<int>)Session["CartItem"];
        //    if (cart == null)
        //    {
        //        return new JsonResult() { Data = new { Status = "ERROR" } };
        //    }
        //    cart.Remove(prodID);

        //    return new JsonResult() { Data = new { Status = "Success" } };
        //}
    }
}