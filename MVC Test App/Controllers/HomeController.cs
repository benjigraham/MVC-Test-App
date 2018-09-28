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
            vm.employeeList = Employees.empList;
            
            return View(vm);
        }

        public ActionResult EmployeeDetails(int id)
        {
            
            var employee = Employees.empList.SingleOrDefault(i => i.ID == id);
            return View(employee);
                
        }

        public ActionResult EmployeeDetails(Employee employee)
        {

            
            return View(employee);

        }

        public ActionResult Edit(int id)
        {
            var employee = Employees.empList.SingleOrDefault(i => i.ID == id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            Employees.editListItem(employee);
            return View("EmployeeDetails", employee);
        }

        public ActionResult Create()
        {

            return View("NewEmployee");
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            Employees.addToList(employee);
            return View("EmployeeDetails", employee);
        }





    }

    public static class Employees
    {
        public static List<Employee> empList = new List<Employee> {
            new Employee(1, "Bob", "Cobb", "Active", "General", "918-555-5555", "bobcobb@myCompany.com", "1234 Mega Drive", "", "Dallas", "TX", "75001"),
            new Employee(2, "Bobbie", "Cobb", "Active", "HR", "918-555-5555", "bobbiecobb@myCompany.com", "1234 Mega Drive", "", "Dallas", "TX", "75001"),
            new Employee(3, "Mary", "Sue", "Active", "Manager", "918-555-5555", "marysue@myCompany.com", "4567 5th Avenue", "", "Dallas", "TX", "75001"),
            new Employee(4, "Gary", "Stu", "Inactive", "Cashier", "918-555-5555", "garystu@myCompany.com", "4567 5th Avenue", "", "Dallas", "TX", "75001")
        };



        public static void addToList(Employee employee)
        {
            empList.Add(new Employee(
                empList.Count() + 1,
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

        public static void editListItem(Employee employee)
        {
            var index = empList.FindIndex(i => i.ID == employee.ID);
            empList[index] = employee;

            
        }
    }
}