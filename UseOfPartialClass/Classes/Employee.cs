using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfPartialClass.Classes
{
    partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
    }

    //This can be a part of another assembly with public access specifier
    partial class Employee
    {
        public string LastName { get; set; } = string.Empty;

        public void PrintData(Employee employee)
        {
            Console.WriteLine(employee.EmployeeId);
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
        }

    }
}
