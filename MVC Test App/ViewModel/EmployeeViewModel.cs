using MVC_Test_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test_App.ViewModel
{
    public class EmployeeViewModel
    {
        public Employee employee { get; set; }
        public List<Employee> employeeList { get; set; }


        public EmployeeViewModel()
        {
            employeeList = new List<Employee>();
            employeeList.Add(new Employee("Bob", "Cobb", "Active", "General", "918-555-5555", "bobcobb@myCompany.com", "1234 Mega Drive", "", "Dallas", "TX", "75001"));
            employeeList.Add(new Employee("Bobbie", "Cobb", "Active", "HR", "918-555-5555", "bobbiecobb@myCompany.com", "1234 Mega Drive", "", "Dallas", "TX", "75001"));
            employeeList.Add(new Employee("Mary", "Sue", "Active", "Manager", "918-555-5555", "marysue@myCompany.com", "4567 5th Avenue", "", "Dallas", "TX", "75001"));
            employeeList.Add(new Employee("Gary", "Stu", "Inactive", "Cashier", "918-555-5555", "garystu@myCompany.com", "4567 5th Avenue", "", "Dallas", "TX", "75001"));
        }


    }
}