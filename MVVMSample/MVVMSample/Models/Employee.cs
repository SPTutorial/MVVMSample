using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMSample.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class PhoneContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public string Name { get => $"{FirstName} {LastName}"; }

    }
}
