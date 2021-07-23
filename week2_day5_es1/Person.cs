using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day5_es1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }

        public Person()
        {

        }

        public Person(string firstname, string lastname, string code)
        {
            FirstName = firstname;
            LastName = lastname;
            Code = code;
        }
    }
}
