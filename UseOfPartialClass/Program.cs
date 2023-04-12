using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseOfPartialClass.Classes;

namespace UseOfPartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmployeeId = 1;
            employee.FirstName = "Vijay";
            employee.LastName = "Balkawade";

            employee.PrintData(employee);
            Console.ReadLine();
        }
    }
}
