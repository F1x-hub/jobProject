using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal  class Developer : Employee
    {
        public double HourlyRate { get; set; }

        public override double CalculateSalary()
        {
            return HourlyRate * double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString()+ $" - HourlyRate: {HourlyRate}";
        }
    }
}
