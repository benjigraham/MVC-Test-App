using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test_App.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpStatus { get; set; }
        public string Department { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { set; get; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string FullAddress
        {
            get { return Address1 + " " + (Address2 == null || Address2 == "" ? "" : (Address2 + " ")) + City + ", " + State + " " + Zip; }

        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
          


        public Employee()
        { }

        public Employee(int id, string first, string last, string status, string dept, string phone, string email, string add1, string add2, string city, string state, string zip)
        {
            ID = id;
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