using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Test_App.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Employment Status")]
        public string EmpStatus { get; set; }
        public string Department { get; set; }
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNum { get; set; }
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { set; get; }
        public string City { get; set; }        
        public string State { get; set; }
        [DataType(DataType.PostalCode)]
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