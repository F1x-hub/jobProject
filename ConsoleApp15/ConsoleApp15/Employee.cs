using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public abstract double CalculateSalary();
        public override string ToString()
        {
            return $"Id: {EmployeeId} - FirstName: {FirstName} - LastName: {LastName} - Salary: {Salary}";
        }
    }
}
