using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        private decimal monthlySalary;

        public Employee(string firstName,string lastName,decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if(value>= OM)
                {
                    monthlySalary = value;
                }
            }
        }

        public decimal OM { get; private set; }

        public override string ToString() =>
            $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
    }
}
