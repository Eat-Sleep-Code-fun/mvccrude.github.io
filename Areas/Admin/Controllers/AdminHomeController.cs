using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Admin/AdminHome
        public ActionResult Dashboard()
        {
            if(Session["UID"]!=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
           
        }
    }
}