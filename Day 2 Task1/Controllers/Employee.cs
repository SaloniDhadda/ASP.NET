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
                context.AddEmp(e);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Requesttype = Request.Method;
                ViewBag.ErrorMessage = "Invalid Details";
                return View();
            }

        }
        public IActionResult Details(int Id)
        {
            employee e1 = context.GetDetailsByID(Id);
            return View(e1);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            employee e1 = context.GetDetailsByID(Id);
            return View(e1);
        }
        [HttpPost]
        public IActionResult Edit(employee e1)
        {
            if (ModelState.IsValid == true)
            {
                context.UpdateEmp(e1);
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
        public IActionResult Delete(int Id)
        {
            employee e1 = context.GetDetailsByID(Id);
            return View(e1);
        }
        [HttpPost]
        public IActionResult deleteConfirm(int Id)
        {
            context.DeleteEmp(Id);
            return RedirectToAction("Index");

        }

    }
}


