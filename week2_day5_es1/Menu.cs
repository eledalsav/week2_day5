using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day5_es1
{
    class Menu
    {
        internal static void Start()
        {
            Console.WriteLine("Benvenuto!\n");
            int option;
            do
            {
                Console.WriteLine("*****Menu*****\n");
                Console.WriteLine("1. Visualizza tutti gli impiegati");
                Console.WriteLine("2. Mostra gli impiegati appartenenti ad un detereminato settore");
                Console.WriteLine("3. Inserisci un nuovo impiegato");
                Console.WriteLine("4. Elimina un impiegato");
                Console.WriteLine("5. Visualizza gli impiegati con stipendio maggiore o uguale di un certo importo");
                Console.WriteLine("0. Esci dal programma\n");

               Console.WriteLine("Cosa desideri fare?");
                while(!int.TryParse(Console.ReadLine(), out option)|| option <0|| option > 5)
                {
                    Console.WriteLine("Scelta non valida, riprova:");
                }
                Console.WriteLine();
                
                switch (option)
                {
                    case 1:
                        EmployeeManager.ViewEmployees();//mostra la lista di impiegati 
                        break;
                    case 2:
                        ViewTradeEmployees();//mostra gli impiegati appartenenti ad un certo settore
                        break;
                    case 3:
                        AddEmployee();//aggiunge un impiegato
                        break;
                    case 4:
                        DeleteEmployee();//elimina un impiegato
                        break;
                    case 5:
                        ViewSalary();
                        break;
                    default:
                       break;
                    case 0:
                        return;

                }


            } while (option != 0);
        }

        private static void ViewSalary()
        {
            bool check3;
            int importo;
            do
            {
                Console.WriteLine("Inserisci l'importo:");
                check3 = int.TryParse(Console.ReadLine(), out importo);
            } while (check3 == false);
            EmployeeManager.ViewSalaryImporto(importo);
            Console.WriteLine();
        }

        private static void DeleteEmployee()
        {
            string Code;
            Employee employee;
            do
            {
                Console.WriteLine("Inserisci il codice fiscale dell'impiegato che vuoi eliminare:");
                Code = Console.ReadLine();
                employee = EmployeeManager.GetByCode(Code);//restituisce un impiegato con quel codice fiscale o ci dice che non esiste
                if(employee== null)
                {
                    Console.WriteLine("Impiegato inesistente, inserisci un altro codice fiscale:");
                }

            } while (employee==null);
            EmployeeManager.DelteAEmployee(Code);
            Console.WriteLine("Impiegato eliminato.\n");
        }

        private static void AddEmployee()
        {
            string FirstName, LastName, Code;
            int Trade;
            Employee employee;
            bool check;
            do
            {
                Console.WriteLine("Inserisci il codice fiscale del nuovo impiegato:");
                Code = Console.ReadLine();
                employee = EmployeeManager.GetByCode(Code);//restituisce l'impiegato con quel codice fiscale

                if (employee != null)
                {
                    Console.WriteLine("Attenzione! Impiegato già esistente");
                    Console.WriteLine();
                }

            } while (employee != null);

            Console.WriteLine("Inserisci il nome:");
                FirstName = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome:");
                LastName = Console.ReadLine();
                do
                {
                    Console.WriteLine($"Premi {(int)EnumTrade.Vendite} per scegliere {EnumTrade.Vendite}");
                    Console.WriteLine($"Premi {(int)EnumTrade.Amministrazione} per scegliere {EnumTrade.Amministrazione}");
                    Console.WriteLine($"Premi {(int)EnumTrade.Sviluppo} per scegliere {EnumTrade.Sviluppo}");
                    check = int.TryParse(Console.ReadLine(), out Trade);
                    if(check == false || Trade < 0 || Trade > 2)
                    {
                        Console.WriteLine("Attenzione, scelta non valida.");
                    };
                } while (check == false || Trade < 0 || Trade > 2);

            EmployeeManager.AddNewEmployee(FirstName, LastName, Code, (EnumTrade)Trade);//aggiunge un nuovo impiegato alla lista con i dati forniti
            Console.WriteLine($"Impiegato {FirstName} {LastName} aggiunto con successo!\n");

        }

        private static void ViewTradeEmployees()
        {
            bool check2;
            int trade;
            Employee employee;
            do
                {
                    Console.WriteLine("Quale settore ti interessa?");
                    Console.WriteLine($"Premi {(int)EnumTrade.Vendite} per scegliere {EnumTrade.Vendite}");
                    Console.WriteLine($"Premi {(int)EnumTrade.Amministrazione} per scegliere {EnumTrade.Amministrazione}");
                    Console.WriteLine($"Premi {(int)EnumTrade.Sviluppo} per scegliere {EnumTrade.Sviluppo}");
                    check2 = int.TryParse(Console.ReadLine(), out trade);
                    if (check2 == false || trade < 0 || trade > 2)
                    {
                        Console.WriteLine("Attenzione, scelta non valida.");
                    };
                } while (check2 == false || trade < 0 || trade > 2);
            Console.WriteLine("\nImpiegati presenti:");
                employee = EmployeeManager.GetByTrade(trade);
            Console.WriteLine();

        }
    }
}
