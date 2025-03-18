using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCsharp1.BLogic
{
    public class Iterations
    {
        int loopNumber = 0;
        string[] stringsName;
        bool isOK = true;

        public Iterations(int LoopNumber) {
            loopNumber = LoopNumber;

        }

        public Iterations(int LoopNumber, string[] StringsName)
        {
            loopNumber = LoopNumber;
            stringsName = new string[StringsName.Length];
            stringsName = StringsName;
        }

        public Iterations() 
        {
        }

        public void ForIterattions()
        {
            for (int i = 0; i < loopNumber; i++)
            {
                Console.WriteLine($"For loop: {i}");
            }
        }

        public void ForeachIterations()
        {
            foreach (var item in stringsName)
            {
                Console.WriteLine($"Foreach loop: {item}");
            }
        }

        public void WhileIterations()
        {
            string inputText = string.Empty;
            while (isOK)
            {
                Console.Write("Scrivi qualcosa(fine per uscire dal do while)");
                inputText = Console.ReadLine();
                isOK = inputText.ToLower() != "fine" ? true : false;
            }
        }

        public void DoWhileIterations()
        {
            
            
            string inputText = string.Empty;
            do
            {
                Console.Write("Scrivi qualcosa(fine per uscire dal while)");
                inputText = Console.ReadLine();
                isOK = inputText.ToLower() != "fine" ? true : false;
            } while (isOK);
        }
    }
}
