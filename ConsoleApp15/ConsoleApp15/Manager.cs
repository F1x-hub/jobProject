using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal  class Manager : Employee
    {
        public double Bonus { get; set; }

        public override double CalculateSalary()
        {
            return Bonus + double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString() +$" - Bonus: {Bonus} ";
        }
    }
}
