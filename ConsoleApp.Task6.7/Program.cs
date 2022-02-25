using System;

namespace ConsoleApp.Task6._7
{
    internal class Program
    {
        /*7)  Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?*/
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();
            string word = "12Az22erbaycan";
            word = word.ToLower();

            int countA = word.IndexOf('a');
            int countB = word.IndexOf('b');
            int countC = word.IndexOf('c');

            Console.WriteLine($"a herfinin indeksi {countA}");
            Console.WriteLine($"b herfinin indeksi {countB}");
            Console.WriteLine($"c herfinin indeksi {countC}");

            if (countA < countB && countB < countC)
            {
                Console.WriteLine("Yazilmis metnde 'a','b','c' simvollarindan ilk olaraq 'a' simvolu sonra 'b' simvolu sonra ise 'c' simvolu gelir.");
            }
            else
            {
                Console.WriteLine("Yazilmis metnde 'a','b','c' simvollari ard arda gelmir.");
            }






        }
    }
}
