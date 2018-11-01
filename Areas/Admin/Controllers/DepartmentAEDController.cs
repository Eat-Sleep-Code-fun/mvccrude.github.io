using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminWeb.Models;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class DepartmentAEDController : Controller
    {
        #region Add Departments
        private ManageDEP md = new ManageDEP();
        public ActionResult AddDepartments()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDepartments(FormCollection fc)
        {
            Departmenttbl dep = new Departmenttbl();
            dep.DID = Convert.ToInt32(fc["hdnID"]);
            dep.DName_ = fc["depname"];
            dep.DHOD = fc["dephod"];
           int op = md.AddEditDeleteDepartment(dep, 1);

            if (op > 0)
            {
                    ViewBag.msg = "Data Saved";
            }
            else
            {
                ViewBag.msg = "Try Again";
            }


            return View();
        }
        #endregion

        #region View All Departments
        public ActionResult ViewDEP()
        {
            return View(md.GetDepartments());
        }
        #endregion

        #region Edit Departments
        public ActionResult EditDepartments(int id)
        {
            var department = md.GetDepartmentbyID(id);

            return View(department);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDepartments(FormCollection fc, int id)
        {
            Departmenttbl dep = new Departmenttbl();
            dep.DID = Convert.ToInt32(fc["hdnID"]);
            dep.DName_ = fc["depname"];
            dep.DHOD = fc["dephod"];
            int op = md.AddEditDeleteDepartment(dep, 2);

            if (op > 0)
            {
               TempData["msg"] = "Data Updated";
                return RedirectToAction("ViewDEP");
            }
            else
            {
                TempData["msg"] = "Try Again";
                return View();
            }

        }
        #endregion

        #region Delete Departments
        public ActionResult DeleteDeparetments(int id)
        {
            var department = md.GetDepartmentbyID(id);
            if (department!=null)
            {
                int op = md.AddEditDeleteDepartment(department, 3);
                if (op > 0)
                {
                    TempData["msg"] = "Data Deleted";
                    return RedirectToAction("ViewDEP");
                }
                else
                {
                    TempData["msg"] = "Try Again";
                    return View();
                }
            }
            return View();
        }
        #endregion
    }
}