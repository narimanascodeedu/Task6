using System;

namespace ConsoleApp.Task6._14
{
    internal class Program
    {
        /*14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen  simvolun BOYUK formasi ile evez et.*/
        static void Main(string[] args)
        {

            string word = "idman";//DdAa

            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result = result + word[i].ToString().ToUpper();
                }

            }
            Console.WriteLine(result);
        }
    }
}
