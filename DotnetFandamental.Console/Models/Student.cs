using DotnetFandamental.Console.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFandamental.Models
{
    //DataType
    //Model Our World for Computer
    //Class = Proprty + Method
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string NationalCode { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public Grade Grade { get; set; }
        public string FullName { get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
