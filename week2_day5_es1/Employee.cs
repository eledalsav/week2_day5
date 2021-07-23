using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day5_es1
{
    class Employee:Person
    {
        public EnumTrade Trade { get; set; }

        public void SalaryCalculation()
        {

        }

        public Employee(string firstname, string lastname, string code, EnumTrade trade)
            :base(firstname, lastname, code)
        {
            Trade = trade;
        }

    }
    enum EnumTrade
    {
        Vendite, 
        Amministrazione,
        Sviluppo,
    }
}
