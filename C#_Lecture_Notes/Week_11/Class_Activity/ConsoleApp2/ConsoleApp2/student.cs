using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class student
    {
        public string Name;
        public double Mark;
        public double Payment;
        public string Faculty;

        public student(string name,double mark,double payment,string faculty)
        {
            Name = name;
            Mark = mark;
            Payment = payment;
            Faculty = faculty;
        }

        public double payment
        {
            get
            {
                return payment;
            }
            set
            {
                if (value == 100 || value == 200 || value==300)
                {
                    payment = value;
                }
            }
        }

        public override string ToString() =>
            $"{Name,-10} {Mark,-10} {Payment,10:C} {Faculty,10:C}";
    }
}
