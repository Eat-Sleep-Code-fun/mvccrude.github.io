using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminWeb.Models;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {

        #region Login 
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Login(FormCollection fc)
        {
            string Email = fc["email"];
            string Password = fc["pwd"];
           

            AuthUser auth = new AuthUser();
            User user = auth.CheckUserLogin(Email , Password);

            if(user!=null)
            {
                Session["UID"] = user.UID;
                Session["UEmail"] = user.UEmailID;
                Session["UFname"] = user.UFname_;
                return RedirectToAction("Dashboard", "AdminHome");
            }
            else
            {
                return View();
            }
        }
        #endregion

        #region Logout
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
        #endregion
    }
}