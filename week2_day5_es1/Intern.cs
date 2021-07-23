using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day5_es1
{
    class Intern:Employee
    {
        public int NumberOfMonths { get; set; }

        public new int SalaryCalculation()
        {
            int Salary = NumberOfMonths * 600;
            return Salary;
        }

        public Intern(string firstname, string lastname, string code, EnumTrade trade, int numberOfMonths)
            :base(firstname, lastname, code, trade)
        {
            NumberOfMonths = numberOfMonths;
        }
    }
}
