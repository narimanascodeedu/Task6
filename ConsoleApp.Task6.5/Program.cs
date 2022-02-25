using System;

namespace ConsoleApp.Task6._5
{
    internal class Program
    {
        /*5) Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan  hansi birinci gelir? */
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();

            string word = "22qwert";

            word = word.ToLower();

            char[] symbols = { 'a', 'b', 'c' };

            int index = word.IndexOfAny(symbols);


            if (index == -1)
            {
                Console.WriteLine("Yazilmis metnde 'a', 'b', 'c' simvollarindan hec biri yoxdur.");
                return;
            }


            Console.WriteLine($"Yazilmis metnde ilk olaraq '{word[index]}' simvolu gelir.");

        }
    }
}
