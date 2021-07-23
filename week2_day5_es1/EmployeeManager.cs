using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day5_es1
{
    class EmployeeManager
    {
        static List<Employee> employees = new List<Employee>
        {
            new Technician("Mario", "Rossi", "MRARSS87",EnumTrade.Sviluppo, 9, 160),
            new Intern("Silvia", "Bianchi", "SLVBNC98", EnumTrade.Vendite, 6),
            new Manager("Alberto", "Piccoli", "ALBPCC54", EnumTrade.Amministrazione, 5, 1800),

        };

        internal static void ViewEmployees()
        {
            Console.WriteLine("\nEcco gli impiegati:");
            foreach (Employee employee in employees)
            {
                if (employee is Technician)
                {
                    Technician technician = (Technician)employee;
                    Console.WriteLine(technician.FirstName + " " + technician.LastName + " " + technician.Code + " " + technician.Trade + " " + technician.SalaryCalculation());
                }
                else if (employee is Intern)
                {
                    Intern intern = (Intern)employee;
                    Console.WriteLine(intern.FirstName + " " + intern.LastName + " " + intern.Code + " " + intern.Trade + " " + intern.SalaryCalculation());
                }
                else if (employee is Manager)
                {
                    Manager manager = (Manager)employee;
                    Console.WriteLine(manager.FirstName + " " + manager.LastName + " " + manager.Code + " " + manager.Trade + " " + manager.SalaryCalculation());
                }

            }
            Console.WriteLine();
        }

        internal static Employee GetByTrade(int trade)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Trade == (EnumTrade)trade)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);//stampa nome e cognome degli impiegati in un determinato settore
                    return employee;
                }
            }
            return null;
        }

        internal static Employee GetByCode(string code)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Code == code)
                {
                    return employee;
                }

            }
            return null;
        }

        internal static void AddNewEmployee(string firstname, string lastname, string code, EnumTrade trade)
        {
            Employee newemployee = new Employee(firstname, lastname, code, trade);
            employees.Add(newemployee);
        }

        internal static void DelteAEmployee(string code)
        {
            employees.Remove(GetByCode(code));
        }

        internal static void ViewSalaryImporto(int importo)
        {
            Console.WriteLine($"Ecco gli impiegati con stipendio superiore a {importo}:");
            foreach (Employee employee in employees)
            {
                if (employee is Technician)
                {
                    Technician technician = (Technician)employee;
                    if (technician.SalaryCalculation() >= importo)
                    {
                        Console.WriteLine(technician.FirstName + " " + technician.LastName);
                    }
                }
                else if (employee is Intern)
                {
                    Intern intern = (Intern)employee;
                    if (intern.SalaryCalculation() >= importo)
                    {
                        Console.WriteLine(intern.FirstName + " " + intern.LastName);
                    }
                }
                else if (employee is Manager)
                {
                    Manager manager = (Manager)employee;
                    if (manager.SalaryCalculation() >= importo)
                    {
                        Console.WriteLine(manager.FirstName + " " + manager.LastName);
                    }
                }
                
            }
        }
    }
}
