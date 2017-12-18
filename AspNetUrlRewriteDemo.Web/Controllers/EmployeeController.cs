using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetUrlRewriteDemo.Model;

namespace AspNetUrlRewriteDemo.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> employeeList = new List<Employee> { 
            new Employee(){ID=1,Name="Jake", Salary=5000},
            new Employee(){ID=2,Name="Xin", Salary=6000},
            new Employee(){ID=3,Name="Zongze", Salary=7000}
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            ViewBag.List = employeeList;
            return View();
        }

        public ActionResult Detail(int id = 1)
        {
            Employee em = employeeList.FirstOrDefault(e => e.ID == id);
            ViewBag.Employee = em;
            return View();
        }
    }
}
