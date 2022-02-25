using System;

namespace ConsoleAppTask6._3
{
    internal class Program
    {
        /*3)  Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.*/
        static void Main(string[] args)
        {
            Console.Write("metni daxil edin: ");
            string word = Console.ReadLine();

            //string word = "abab";
            word = word.ToLower();

            char b = 'b';

            int digit = 1;

            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (word[i] == b)
                    {
                        digit = 2;
                        counter++;
                    }
                }

            }
            if (digit == 2)
            {
                Console.WriteLine($"Yazilmis metnde 'b' simvollarinin {counter} ededi tek yerde dayanib");
            }
            else
            {
                Console.WriteLine("Yazilmis metnde tek yerde dayanan 'b' simvolu yoxdur ");
            }

        }
    }
}
