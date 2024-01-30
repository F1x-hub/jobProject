using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory() { SalaryForEmployee = 50000};
            List<Employee> employees = new List<Employee>()
            {
                
                new Manager(){EmployeeId = 1, FirstName = "johan", LastName = "jackson", Bonus = 400},
                new Directory(){ EmployeeId = 2, FirstName = "joe", LastName = "smith"},
                new Developer(){ EmployeeId = 3, FirstName = "morty", LastName = "anderson", HourlyRate = 20},
                new Admin(){ EmployeeId = 4, FirstName = "bob", LastName = "bobson", HourlyRate = 15}

            };

            directory.ManageCRUD( employees);
        }
    }
}
