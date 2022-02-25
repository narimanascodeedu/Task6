using System;
using System.Text;

namespace ConsoleAppTask6._11
{
    internal class Program
    {
        /*11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu  ve
         eyni zamandan butun {b} simvollarinin qabagina {a} simvolunu yaz.*/
        static void Main(string[] args)
        {
            string word = "azerbaycan fve 10dsc"; //bazerabbaycban

            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    result = result + 'b';
                }
                else if (word[i] == 'b')
                {
                    result = result + 'a';
                }
                result = result + word[i];
            }
            Console.WriteLine(result);
        }
    }
}
