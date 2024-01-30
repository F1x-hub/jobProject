using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Directory : ManageEmployee
    {
        CRUD CRUD = new CRUD();
        

        

        public double SalaryForEmployee { get; set; }

        public override double CalculateSalary()
        {
            return SalaryForEmployee ;
        }

        public override void ManageCRUD(List<Employee> employees)
        {
            int control = 0;
            while(control != 4)
            {

                Console.WriteLine("1. Directoory\n2. Admin\n3. Employees Salary\n4. Exit");
                control = int.Parse(Console.ReadLine());
                
               
                
                if (control == 1)
                {
                        
                    CRUD.MenuCRUD(this, employees);
                }
                if (control == 2)
                {
                        
                    CRUD.AdminCRUD(employees);
                }
                if (control == 3)
                {
                    CRUD.print(employees);
                }
                    
                
            }


        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
