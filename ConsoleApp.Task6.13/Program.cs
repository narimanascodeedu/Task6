using System;
using System.Text;

namespace ConsoleApp.Task6._13
{
    internal class Program
    {
        /*13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et.*/
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string word = "azerbaycan";

            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                if(i % 2 == 0 )
                {
                    result = result + word[i].ToString().ToUpper();
                }
                else 
                {
                    result = result + word[i].ToString().ToLower();
                }
            }
            Console.WriteLine(result);


            // AXIRKI ... COX CETIN OLDU
        }
    }
}
