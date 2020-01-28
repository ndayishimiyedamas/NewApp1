using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewApp.Models;
using NewApp.ViewModel;

namespace NewApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeData _employeeData;
        private IEmployeeData _employeeDataData;

        public HomeController(IEmployeeData restaurantData)
        {
            _employeeDataData = restaurantData;
        }
        // GET
        public IActionResult Index()
        {
           
            var Employee = new HomeViewModel();
            Employee.Employee = _employeeDataData.GetAll();
            return View(Employee);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee {Name = model.Name, Name = model.Name};
                _employeeDataData.Add(Employee);
                

                return RedirectToAction("Details", new {id = restaurant.Id}); // TODO :fix redirection to details

            }

            return View();
        }

        public IActionResult Details(int id)
        {
            var Employee = _employeeDataData.Get(id);

            if (Employee == null)
            {
                return RedirectToAction("Index");
            }

            return View(Employee);
        }
    }

    public interface IEmployeeData
    {
        object GetAll();
    }
}