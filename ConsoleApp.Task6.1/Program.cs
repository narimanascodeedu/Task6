using System;

namespace ConsoleApp.Task6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "abxdsbcxabb";

            int countA = 0;
            int countB = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    countA++;
                }
                else if (word[i] == 'b')
                {
                    countB++;
                }
            }
            double cavab = countA * 1.0 / countB;
            Console.WriteLine(countA);
            Console.WriteLine(countB);
            Console.WriteLine(cavab);
        }
    }
}
