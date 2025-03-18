using StartCsharp1.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StartCsharp1.BLogic
{
    class Start
    {
        #region public methods
        // If I need to put an optional param, I can just initialize it with null and position it after the required params

        /// <summary>
        /// Welcome message
        /// </summary>
        internal static void ShowMenu()
        {
            string? msg = null;

            while (NameValidation(msg))
            {
                Console.Clear();
                Console.WriteLine("BENVENUTO, COME TI CHIAMI?");

                // I've created a string msg that is an object 
                msg = Console.ReadLine(); // the question mark is used to allow the variable to be null

                // validName checker
                Console.ForegroundColor = ConsoleColor.Red;
                if (NameValidation(msg)) 
                {
                    Console.WriteLine("Premere INVIO per riprovare");
                    Console.ReadLine();
                }
                Console.ResetColor();

            }
            string menuDescription = $"Benvenuto {msg}, come posso aiutarti?";

            //if (msg != string.Empty && msg != null)

            WriteMenu(menuDescription, msg);
        
        
        }
        #endregion

        #region private methods
        /// <summary>
        /// it writes the menu
        /// </summary>
        /// <param name="msg">The name of the user</permission>"
        /// <param name="menuDescription">The description of the menu</param>
        static void WriteMenu(string menuDescription, string? msg)
        {
            string menuChoice = string.Empty;

            while (menuChoice != "9")
            {
                Console.Clear();
                Console.WriteLine(new string('-', menuDescription.Length + 1));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(menuDescription);
                Console.ResetColor();
                Console.WriteLine(new string('-', menuDescription.Length + 1));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Esecuzione metodi classe Iterations");
                Console.WriteLine("2. Esecuzione metodi classe DemoArrayList");
                Console.WriteLine("3. Test Enumerators");
                Console.WriteLine("4. Gestione Employees");
                Console.WriteLine("9. Chiudi l'applicazione.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Scegliere la funzione da eseguire: ");
                Console.ResetColor();

                menuChoice = Console.ReadLine().ToUpper();
                Console.WriteLine();

                // try to convert the string to an int, if it fails, it returns false
                bool resultChoice = int.TryParse(menuChoice, out int menuItem);

                if (menuItem > 0)
                {
                    switch ((MainEnumerators.MenuItems)menuItem)
                    {
                        case MainEnumerators.MenuItems.Iterations:
                            Iterations();
                            break;
                        case MainEnumerators.MenuItems.DemoArrayList:
                            DemoArrayList();
                            break;
                        case MainEnumerators.MenuItems.TestEnums:
                            DemoEnums();
                            break;
                        case MainEnumerators.MenuItems.Employees:
                            EmployeeMenu(); //gestire dipendenti menu
                            break;
                        case MainEnumerators.MenuItems.ExitProgram:
                            return;
                    }
                }
                if ((MainEnumerators.MenuItems)menuItem != MainEnumerators.MenuItems.ExitProgram)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Premere il tasto INVIO per continuare");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// EmployeeMenu
        /// </summary>
        static void EmployeeMenu()
        {
            string employeeHeader = "MENU GESTIONE DIPENDENTI";
            string? employeeMenuChoice = string.Empty;

            while (employeeMenuChoice != "9")
            {
                Console.Clear();
                Console.WriteLine(new string('-', employeeHeader.Length + 1));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{employeeHeader}");
                Console.ResetColor();
                Console.WriteLine(new string('-', employeeHeader.Length + 1));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Aggiungi dipendente");
                Console.WriteLine("2. Elimina dipendente");
                Console.WriteLine("3. Modifica dipendente");
                Console.WriteLine("4. Visualizza dipendenti");
                Console.WriteLine("9. Esci");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Scegliere la funzione da eseguire: ");
                Console.ResetColor();

                employeeMenuChoice = Console.ReadLine().ToUpper();

                // try to convert the string to an int, if it fails, it returns false
                bool resultChoice = int.TryParse(employeeMenuChoice, out int employeeMenuItems);

                if (employeeMenuItems > 0)
                {
                    switch ((MainEnumerators.EmployeeMenuItems)employeeMenuItems)
                    {
                        case MainEnumerators.EmployeeMenuItems.AddEmployee:
                            //AddEmployee();
                            break;
                        case MainEnumerators.EmployeeMenuItems.RemoveEmployee:
                            //RemoveEmployee();
                            break;
                        case MainEnumerators.EmployeeMenuItems.ModifyEmployee:
                            //ModifyEmployee();
                            break;
                        case MainEnumerators.EmployeeMenuItems.SearchEmployee:
                            //SearchEmployee(); //gestire dipendenti menu
                            break;
                        case MainEnumerators.EmployeeMenuItems.ExitProgram:
                            return;
                    }
                }

                if ((MainEnumerators.EmployeeMenuItems)employeeMenuItems != MainEnumerators.EmployeeMenuItems.ExitProgram)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Premere il tasto INVIO per continuare");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            }


        }
        
        /// <summary>
        /// NameValidator
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        static bool NameValidation(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg))
            {
                Console.WriteLine("Non hai inserito nessun nome");
                return true;
            }
            else if (Regex.IsMatch(msg, @"\d")) //  checks if there are any numbers in the string
            {
                Console.WriteLine("Non puoi inserire numeri");
                return true;
            }
            else if (SpecialCharactersChecker(msg))
            {
                Console.WriteLine("Non puoi inserire caratteri speciali");
                return true;
            } else
            {
                return false;
            }

        }
        
        /// <summary>
        /// DemoEnums
        /// </summary>
        static void DemoEnums()
        {
            EnumsTest.CarEnums();
        }

        /// <summary>
        /// It checks if there are special characters in th name
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        static bool SpecialCharactersChecker(string msg)
        {
            string pattern = @"\|!#%&/=»?«@'£§€{}-;'.<>_,";
            foreach (var item in pattern)
            {
                if (msg.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Iterations
        /// </summary>
        static void Iterations()
        {
            //Iterations
            Console.WriteLine("Esecuzione metodi classe Iterations");
            string[] strings = new string[3] { "uno", "due", "tre" };
            Iterations iterations = new Iterations(10, strings);
            iterations.ForIterattions();
            iterations.ForeachIterations();
            iterations.WhileIterations();
            iterations.DoWhileIterations();
        }

        static void DemoArrayList()
        {
            ArrayAndList arrayAndList = new ArrayAndList();
            arrayAndList.PrintArray();
            arrayAndList.PrintListValues();
            arrayAndList.StringManipulation();
        }

        static void EmployeesHandler()
        {
            // creare un menu di gestione dei dipendenti 
            Employee employee = new();
        }

        #endregion
    }
}




