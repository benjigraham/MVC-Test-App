using MVC_Test_App.Models;
using System.Collections.Generic;

namespace MVC_Test_App.ViewModel
{
    public class EmployeeListViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public string Department { get; set; }
    }
}