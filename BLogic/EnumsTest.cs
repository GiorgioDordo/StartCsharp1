using StartCsharp1.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCsharp1.BLogic
{
    class EnumsTest
    {
        internal static void CarEnums ()
        {
            int myEngine = 2500;
            int currentEngine = 5;

            try
            {
                // test per scatenare l'exception, in C#, la console non puo fare l'operazione
                //int x = 1;
                //Console.WriteLine(x/0);
                Console.WriteLine($"TipoMotore (inesistente): {(MainEnumerators.CarEngine)myEngine}");
                Console.WriteLine($"TipoMotore (esistente): {(MainEnumerators.CarEngine)currentEngine}");
            }
            // input output exception
            catch (IOException ioEx)
            {
                Console.WriteLine($"ATTENZIONE, si è verificato un errore di scrittura sulla console: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Attenzione: Errore imprevisto: {ex.Message}\nContattare l'amministratore di Sistema.");
            }
            finally
            {
                Console.WriteLine("METODO CONCLUSO!");
            }
        }
    }
}
