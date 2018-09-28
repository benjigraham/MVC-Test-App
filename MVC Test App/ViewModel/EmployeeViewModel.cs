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
            
        }


    }
}