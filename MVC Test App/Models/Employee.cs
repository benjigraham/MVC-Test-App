using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test_App.Models
{
    public class Employee
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }   
        private string EmpStatus { get; set; }
        private string Department { get; set; }
        private string PhoneNum { get; set; }
        private string Email { get; set; }
        private string Address1 { get; set; }
        private string Address2 { set; get; }
        private string City { get; set; }
        private string State { get; set; }
        private string Zip { get; set; }

        private string FullAddress
        {
            get { return Address1 + " " + (Address2 == null || Address2 == "" ? "" : (Address2 + " ")) + City + ", " + State + " " + Zip; }
            
        }


        public Employee()
        { }

        public Employee(string first, string last, string status, string dept, string phone, string email, string add1, string add2, string city, string state, string zip)
        {
            FirstName = first;
            LastName = last;
            EmpStatus = status;
            Department = dept;
            PhoneNum = phone;
            Email = email;
            Address1 = add1;
            Address2 = add2;
            City = city;
            State = state;
            Zip = zip;
        }


    }
}