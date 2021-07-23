using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day5_es1
{
    class Manager:Employee
    {
        public int OvertimeHours { get; set; }
        public int BasicSalary { get; set; }

        public new int SalaryCalculation()
        {
            int Salary = BasicSalary + (OvertimeHours * 10);
            return Salary;
        }

        public Manager(string firstname, string lastname, string code, EnumTrade trade, int overtimeHours, int basicSalary)
            : base(firstname, lastname, code, trade)
        {
            OvertimeHours = overtimeHours;
            BasicSalary = basicSalary;
        }
    }
}
