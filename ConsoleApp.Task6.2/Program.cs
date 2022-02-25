using System;

namespace ConsoleApp.Task6._2
{
    internal class Program
    {
        /*2)  Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?*/
        static void Main(string[] args)
        {
            string word = "Code Academy";
            word = word.ToLower();

            char a = 'a';

            word = word.ToLower();

            bool yes = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (word[i] == a)
                    {
                        yes = false;
                        break;
                    }
                }
            }
            if (yes == true)
            {
                Console.WriteLine("Yazilmis metnde tek yerde duran simvollar a-ya beraber deyil");
            }
            else
            {
                Console.WriteLine("Yazilmis metnde tek yerde duran simvollar a-ya beraberdir");
            }


        }
    }
}
