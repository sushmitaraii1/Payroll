using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLogin.Models;

namespace MVCLogin.Controllers
{
    public class EmployeeInfoController : Controller
    {
        // GET: EmployeeInfo
        public ActionResult Index()
        {
            using (EmpayeeEntities1 dbModel = new EmpayeeEntities1())
            {
                return View(dbModel.EmployeeInformations.ToList());
            }

        }

        // GET: EmployeeInfo/Details/5
        public ActionResult Details(int id)
        {
            using (EmpayeeEntities1 emp = new EmpayeeEntities1())
            {
                return View(emp.EmployeeInformations.Where(x => x.EmployeeId == id).FirstOrDefault());
            }

        }

        // GET: EmployeeInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeInfo/Create
        [HttpPost]
        public ActionResult Create(EmployeeInformation employee)
        {
            try
            {
                using (EmpayeeEntities1 emp = new EmpayeeEntities1())
                {
                    emp.EmployeeInformations.Add(employee);
                    emp.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeInfo/Edit/5
        public ActionResult Edit(int id)
        {
            using (EmpayeeEntities1 emp = new EmpayeeEntities1())
            {
                return View(emp.EmployeeInformations.Where(x => x.EmployeeId == id).FirstOrDefault());
            }
        }

        // POST: EmployeeInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeInformation employee)
        {
            try
            {
                using (EmpayeeEntities1 emp = new EmpayeeEntities1())
                {
                    emp.Entry(employee).State = EntityState.Modified;
                    emp.SaveChanges();

                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeInfo/Delete/5
        public ActionResult Delete(int id)
        {
            using (EmpayeeEntities1 emp = new EmpayeeEntities1())
            {
                return View(emp.EmployeeInformations.Where(x => x.EmployeeId == id).FirstOrDefault());
            }
        }

        // POST: EmployeeInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (EmpayeeEntities1 emp = new EmpayeeEntities1())
                {
                    EmployeeInformation employee = emp.EmployeeInformations.Where(x => x.EmployeeId == id).FirstOrDefault();
                    emp.EmployeeInformations.Remove(employee);
                    emp.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
