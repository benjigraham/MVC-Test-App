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
            return View(vm.employee);
                
        }

        public ActionResult Edit(EmployeeViewModel vm, int id)
        {
            var employee = vm.employeeList.SingleOrDefault(i => i.ID == id);
            return View(employee);
        }

        public ActionResult Create()
        {

            return View("NewEmployee");
        }

        //[HttpPost]
        //public ActionResult Create(EmployeeViewModel vm)
        //{
        //    vm.employeeList.Add(new Employee(
        //        vm.employeeList.Count + 1,
        //        vm.employee.FirstName,
        //        vm.employee.LastName,
        //        vm.employee.EmpStatus,
        //        vm.employee.Department,
        //        vm.employee.PhoneNum,
        //        vm.employee.Email,
        //        vm.employee.Address1,
        //        vm.employee.Address2,
        //        vm.employee.City,
        //        vm.employee.State,
        //        vm.employee.Zip
        //        ));

        //    return RedirectToAction("EmployeeDetails", vm.employeeList.Last().ID);
        //}

    }
}