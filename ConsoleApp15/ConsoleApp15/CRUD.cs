using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class CRUD
    {

        Directory directory;
        List<Employee> employees;
        public void MenuCRUD(Directory directory, List<Employee> employees)
        {
            this.directory = directory;
            this.employees = employees;
            int control = 0;

            while (control != 4)
            {
                Console.WriteLine("1. See All Employees\n2. Add Salary\n3. Check Boss Salary\n4. Exit");

                control = int.Parse(Console.ReadLine());

                if (control == 1) 
                {
                    print(employees);
                }
                if (control == 2)
                {
                    Salary();
                }
                if (control == 3)
                {
                    SetDirectorySalary(directory,employees);
                    
                }
            }
        }
        public void SetDirectorySalary(Directory directory2,List<Employee> employees)
        {
            foreach(var employee in employees)
            {
                if(employee is Directory directory)
                {
                    directory.Salary = directory2.SalaryForEmployee;
                    
                    
                    Console.WriteLine($"Boss Salary: {directory.Salary}");
                }
            }
        }
        
        public void Salary()
        {
            int control = 0;

            while (control != 4)
            {
                Console.WriteLine("1. Add Manager Salary\n2. Add Developer Salary\n3. Add Admin Salary\n4. Exit");
                control = int.Parse(Console.ReadLine());

                if (control == 1)
                {
                    Console.Write("Find By Id: ");
                    SetManagerSalary(int.Parse(Console.ReadLine()));
                }
                if (control == 2)
                {
                    Console.Write("Find By Id: ");
                    SetDeveloperSalary(int.Parse(Console.ReadLine()));

                }
                if(control == 3)
                {
                    Console.Write("Find By Id: ");
                    SetAdminSalary(int.Parse(Console.ReadLine()));
                }
            }
        }
        public void SetAdminSalary(int id)
        {
            var employee = FindEmployee(id);

            if (employee is Admin admin)
            {


                Console.Write("Enter The Number Of Working Hours: ");
                admin.Salary = admin.CalculateSalary();
                SetBudget(admin.Salary);
                Console.WriteLine($"New Salary: {admin.Salary}");

            }
            else
            {
                Console.WriteLine("Admin Not Found");
            }
        }
        
        public void SetManagerSalary( int id)
        {

            var employee = FindEmployee(id);

            if (employee is Manager manage)
            {
                
               
                Console.Write("Enter Manager Salary: ");
                    
                manage.Salary = manage.CalculateSalary();
                manage.Bonus = 0;

                    
                Console.WriteLine($"New Salary: {manage.Salary}");
                SetBudget(manage.Salary);

            }
            else
            {
                Console.WriteLine("Manager Not Found");
            }
        }
        
        public void SetDeveloperSalary(int id)
        {
            
            var employee = FindEmployee(id);

            if (employee is Developer developer)
            {
                Console.Write("Enter The Number Of Working Hours: ");
                developer.Salary = developer.CalculateSalary();
                SetBudget(developer.Salary);
                Console.WriteLine($"New Salary: {developer.Salary}");
            }
            else
            {
                Console.WriteLine("Employee Not Found");
            }

            

        }
        public void SetBudget(double Salary)
        {
            this.directory.SalaryForEmployee -= Salary;
            Console.WriteLine($"budget left: {directory.SalaryForEmployee}");
        }
        public Employee FindEmployee(int id)
        {
            foreach (var employee in employees)
            {
                if (employee.EmployeeId == id)
                {
                    return employee;
                }
            }
            return null;
        }
        public void print(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
        public void AdminCRUD(List<Employee> employees)
        {
            int control = 0;
            while (control != 5)
            {
                Console.WriteLine("1. Read Employee\n2. Update Employee\n3. Delete Employee\n4. Exit");
                control = int.Parse(Console.ReadLine());

                if (control == 1)
                {
                    print(employees);
                }
                if (control == 2)
                {
                    UpdateEmployee(employees);
                }
                if(control == 3)
                {
                    DeleteEmployee(employees);
                }
            }

        }
        public void UpdateEmployee(List<Employee> employees)
        {
            Console.Write("Enter Employee Id to Update: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var employee in employees)
            {
                if (employee.EmployeeId == id)
                {

                    Console.Write($"Enter new name for Employee {id}: ");
                    string newName = Console.ReadLine();
                    employee.FirstName = newName;
                    Console.Write($"Enter new last name: ");
                    string newLastName = Console.ReadLine();
                    employee.LastName = newLastName;


                    Console.WriteLine($"Employee {id} updated successfully.");
                }
                
            }

            
        }
        public void DeleteEmployee(List<Employee> employees)
        {
            Console.Write("Enter Employee Id to Delete: ");
            int id = int.Parse(Console.ReadLine());
            for(int i = 0; i < employees.Count; i++) 
            {
                if (employees[i].EmployeeId == id)
                {
                    employees.RemoveAt(i);
                }
            }
        }
    }
}
