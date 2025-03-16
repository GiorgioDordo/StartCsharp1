// if we want to use objects from other classes, we need to import the namespace where the class is located
using StartCsharp1.BLogic;
//using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace StartCsharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // to define an object first we need to define the type of the object and then the name of the object
            Start start = new Start();
            Console.WriteLine("BENVENUTO, COME TI CHIAMI?");

            // I've created a string msg that is an object 
            string msg = Console.ReadLine();

            //if (msg != string.Empty && msg != null)
            if (string.IsNullOrWhiteSpace(msg))
            {
                Console.WriteLine("Non hai inserito nessun nome");
            }
            else if (Regex.IsMatch(msg, @"\d"))
            {
                Console.WriteLine("Non puoi inserire numeri");
            }
            else if (NameValidation(msg))
            {
                Console.WriteLine("Non puoi inserire caratteri speciali");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Benvenuto {msg}, come posso aiutarti?"); ;
            }
        }

        static bool NameValidation(string msg)
        {
            string pattern = @"\|!#%&/=»«@£§€{}-;'<>_,";
            foreach (var item in pattern)
            {
                if (msg.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
