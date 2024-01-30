using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal abstract  class ManageEmployee : Employee
    {
        public abstract override double CalculateSalary();
        

        
        public abstract void ManageCRUD(List<Employee> employees);
    }

    
}
