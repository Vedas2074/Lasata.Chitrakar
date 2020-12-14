using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeManagement.Models;
namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
         public IActionResult Index()
        {
            Department department1 = new Department()
            {
                Id = 1,
                DepartmentName = "Manager",
                Salary = 75000
            };
            Department department2 = new Department()
            {
                Id = 2,
                DepartmentName = "Developer",
                Salary = 50000
            };
            List<Department> departments =  new List<Department>() {department1, department2};

            return View(departments);
        }
        public ActionResult Add()
        {
            
            return View();

        }
        [HttpPost]
         public string Add(Department department)
        {
            
            return "Record Saved";

        }  
    }
}