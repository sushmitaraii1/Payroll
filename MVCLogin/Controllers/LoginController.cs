using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Autherize(MVCLogin.Models.UserManagement userModel)
        {
            using (Models.EmpayeeEntities db = new Models.EmpayeeEntities())
            {
                var userDetaills = db.UserManagements.Where(x => x.Username == userModel.Username && x.Password == userModel.Password).FirstOrDefault();
                if (userDetaills == null)
                {
                    userModel.LogInErrorMessage = "Invalid username or password";
                    return View("Index", userModel);
                }
                else
                {
                    Session["userID"] = userDetaills.UserId;
                    return RedirectToAction("Index", "EmployeeInfo");
                }
            }
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}