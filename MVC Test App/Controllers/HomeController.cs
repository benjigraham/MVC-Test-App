using MVC_Test_App.Models;
using MVC_Test_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewEmployees()
        {
            var vm = new EmployeeViewModel();
            return View(vm);
        }

        public ActionResult EmployeeDetails(int id)
        {
            var vm = new EmployeeViewModel();
            vm.employee = vm.employeeList.SingleOrDefault(i => i.ID == id);
            return View(vm);
                
        }


    }
}