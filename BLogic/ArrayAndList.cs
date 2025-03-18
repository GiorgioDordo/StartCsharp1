using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCsharp1.BLogic
{
    internal class ArrayAndList
    {
        /// <summary>
        /// ARRAYS
        /// </summary>
        private int[] numbersArray = new int[10];
        private float[] numbersArrayValues = {10, 20, 45, 940, 729, 2};
        private string[] stringsArray = new string[5];
        private string[] stringsArrayValue = { "UNO", "DUE", "TRE" };

        /// <summary>
        /// LISTS
        /// </summary>
        List <int> numbersList = new List <int> ();

        internal ArrayAndList() 
        {
            // I change the value ogf index 0
            numbersArray[0] = 1;

            for ( int i = 1; i < numbersArray.Length; i++ )
            {
                numbersArray[i] = i;
            }

            for (int j = 0; j < 5; j++)
            {
                stringsArray[j] = $"Stringa: {j.ToString()}";
            }

            for (int k=0; k <= 100; k+=10)
            {
                numbersList.Add (k);
            }
        }

        internal void PrintArray()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STAMPA ARRAYS NUMERI DI CICLO FOR");
            Console.ResetColor();

            foreach (int i in numbersArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STAMPA ARRAYS STRINGHE CARICATI CON CICLO FOR");
            Console.ResetColor();
            foreach (var item in stringsArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"STAMPO I NUMERI DIVISIBILI PER 5");
            Console.ResetColor();

            for (int i = 0; i < numbersArrayValues.Length; i++ )
            {
                if ( numbersArrayValues[i] % 5 == 0 )
                {
                    Console.WriteLine($"{numbersArrayValues[i]} è divisibile per 5 ed il risultato è {numbersArrayValues[i] / 5}");
                }
            }


            float numbersSum = 0;
            foreach (float item in numbersArrayValues)
            {
                numbersSum += item;
            }

            float numbersAverage = numbersSum / numbersArrayValues.Length;
            Console.WriteLine();
            Console.WriteLine($"Media della collezione numbersArrayValues: {numbersAverage}");

        }

        internal void PrintListValues()
        {
            Console.WriteLine($"La somma dei numeri in numbersArrayValues, vale: {numbersArrayValues.Sum()}");
            Console.WriteLine($"La media dei numeri in numbersArrayValues, vale: {numbersArrayValues.Average()}");
            
            // Lambda expression
            List <int> numbersDividedByTen = numbersList.FindAll(x => (x % 10 == 0) || x == 100);

        }
    }
}
