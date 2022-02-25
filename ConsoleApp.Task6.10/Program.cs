using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp.Task6._10
{
    internal class Program
    {
        /*10) Verilmish metinde butun reqemleri legv et.*/
        static void Main(string[] args)
        {

            int[] numCharCodes = Enumerable.Range(48, 10).ToArray();

            Console.Write("Metni daxil edin: ");
            string text = Console.ReadLine();

            string newText = "";

            byte CharCode;

            for (int i = 0; i < text.Length; i++)
            {
                CharCode = (byte)text[i];

                if (Array.IndexOf(numCharCodes, CharCode) == -1)
                {
                    newText = newText + text[i];
                }
            }

            Console.WriteLine(newText);

        }
    }
}
