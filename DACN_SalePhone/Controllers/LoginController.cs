using DACN_SalePhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DACN_SalePhone.Controllers
{
    public class LoginController : Controller
    {
        

        // GET: Login
        public ActionResult Login(FormCollection fm)
        {
            qlbdtDBEntities db = new qlbdtDBEntities();
            var userEmail = fm["userEmail"];
            var userPassword = fm["userPassword"];

            if (String.IsNullOrEmpty(userEmail))
            {
                ViewData["error"] = "Email không được bỏ trống";
            }
            else if (String.IsNullOrEmpty(userPassword))
            {
                ViewData["PasswordError"] = "Mật khẩu không được bỏ trống";
            }
            else
            {
                user user = db.users.SingleOrDefault(n => n.us_email == userEmail && n.us_password  == userPassword);
                if (user != null)
                {
                    ViewData["error"] = "Đăng nhập thành công";
                    Session["User"] = user.us_id;

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["error"] = "Sai Email hoặc mật khẩu";
                }    
            }    
          
            return View();
        }

        
    }
}