using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;
using System.Linq;


namespace WebApplication2.Controllers
{
    public class Employee : Controller
    {
        DbManager context = new DbManager();
        public IActionResult Index()
        {
            List<employee> empList = context.GetAllDetails();
            return View(empList);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(employee e)
        {
            if (ModelState.IsValid == true)
            {
                context.addemployee(e);
            
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Requesttype = Request.Method;
                ViewBag.ErrorMessage = "Invalid Details";
                return View();
            }

        }
        public IActionResult Details(int id)
        {
            employee e1 = context.GetDetailsByID(id);
            return View(e1);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            employee e1 = context.GetDetailsByID(id);
            return View(e1);
        }
        [HttpPost]
        public IActionResult Edit(employee e1)
        {
            if (ModelState.IsValid == true)
            {
                context.Updatelist(e1);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Requesttype = Request.Method;
                ViewBag.ErrorMessage = "Invalid Details";
                return View();
            }

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            employee e1 = context.GetDetailsByID(id);
            return View(e1);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            context.DeleteEmp(id);
           
            return RedirectToAction("Index");

        }

    }
}


