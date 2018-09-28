using System;
using MVC_Test_App.Models;
using MVC_Test_App.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVC_Test_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewEmployees(string department)
        {
            var empList = Employees.EmpList.Where(n => ShowManager(department, n.Department));


            var vm = new EmployeeListViewModel
            {
                Employees = empList,
                Department = department
            };

            return View(vm);
        }

        public ActionResult EmployeeDetails(int id)
        {
            var employee = Employees.EmpList.SingleOrDefault(i => i.ID == id);
            return View(employee);
        }

        public ActionResult EmployeeDetails(Employee employee)
        {
            return View(employee);
        }

        public ActionResult Edit(int id)
        {
            var employee = Employees.EmpList.SingleOrDefault(i => i.ID == id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            Employees.EditListItem(employee);
            return View("EmployeeDetails", employee);
        }

        public ActionResult Create()
        {
            return View("NewEmployee");
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            Employees.AddToList(employee);
            return View("EmployeeDetails", employee);
        }

        public ActionResult ToggleStatus(int id, bool active)
        {
            Employees.ToggleStatus(id, active);

            return Json(true);
        }

        //Kind of a hackish way to handle the management/non-management drop-down list on the employee grid. There's 
        // almost certainly a better way to do this, but I wanted to just get something done for the purpose of this test

        private bool ShowManager(string lookup, string department)
        {
            if (lookup == "allEmployees") return true;
            var manager = lookup == "Manager";
            var nonManager = lookup == "NonManager";
            if (manager)
            {
                if (department == "Manager")
                    return true;
                if (department == "HR")
                    return true;
                else
                    return false;
            }
            else if (nonManager)
            {
                if (department == "Manager")
                    return false;
                if (department == "HR")
                    return false;
                else
                    return true;
            }
            else
                return true;

        }
    }


    //Static class to have a persisting static list in the app in lieu of a database
    public static class Employees
    {
        public static List<Employee> EmpList = new List<Employee>
        {
            new Employee(1, "Bob", "Cobb", "Active", "General", "918-555-5555", "bobcobb@myCompany.com",
                "1234 Mega Drive", "", "Dallas", "TX", "75001"),
            new Employee(2, "Bobbie", "Cobb", "Active", "HR", "918-555-5555", "bobbiecobb@myCompany.com",
                "1234 Mega Drive", "", "Dallas", "TX", "75001"),
            new Employee(3, "Mary", "Sue", "Active", "Manager", "918-555-5555", "marysue@myCompany.com",
                "4567 5th Avenue", "", "Dallas", "TX", "75001"),
            new Employee(4, "Gary", "Stu", "Inactive", "Cashier", "918-555-5555", "garystu@myCompany.com",
                "4567 5th Avenue", "", "Dallas", "TX", "75001")
        };

        public static void AddToList(Employee employee)
        {
            EmpList.Add(new Employee(
                EmpList.Count + 1,
                employee.FirstName,
                employee.LastName,
                employee.EmpStatus,
                employee.Department,
                employee.PhoneNum,
                employee.Email,
                employee.Address1,
                employee.Address2,
                employee.City,
                employee.State,
                employee.Zip
            ));
        }

        public static void EditListItem(Employee employee)
        {
            var index = EmpList.FindIndex(i => i.ID == employee.ID);
            EmpList[index] = employee;
        }

        public static void ToggleStatus(int id, bool status)
        {
            var emp = EmpList.FirstOrDefault(n => n.ID == id);
            if (emp == null) return;

            emp.EmpStatus = status ? "Active" : "Inactive";
        }
    }
}