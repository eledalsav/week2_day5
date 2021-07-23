using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day5_es1
{
    class Technician:Employee
    {
        public int PayPerHour { get; set; }
        public int Hours { get; set; }

        public new  int SalaryCalculation()
        {
            int Salary = PayPerHour * Hours;
            return Salary;
        }
        
        public Technician(string firstname, string lastname, string code, EnumTrade trade, int payPerHour, int hours)
            :base(firstname,lastname, code, trade)
        {
            PayPerHour = payPerHour;
            Hours = hours;
        }
    }
}
