using System;

namespace ConsoleAppTask6._8
{
    internal class Program
    {
        /*8)  Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.*/
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();
            string word = "22azerbaycan";
            word = word.ToLower();

            int index = word.IndexOf('a');
            string s = word.Substring(index + 1, 1);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(s);
            }

        }
    }
}
