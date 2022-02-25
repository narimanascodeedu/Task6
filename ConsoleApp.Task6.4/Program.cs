using System;

namespace ConsoleApp.Task6._4
{
    internal class Program
    {
        /*4)  Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?*/
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();
            string word = "22Code Academy";
            int index = word.ToLower().IndexOf('a', 0);
            Console.WriteLine(index);
            if (index % 2 == 0)
            {
                Console.WriteLine("Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri cut ededdir");
            }
            else
            {
                Console.WriteLine("Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdir");
            }












            //int index;

            //index = word.ToLower().IndexOf("a", 0);

            //while (index >= 0)
            //{
            //    Console.WriteLine(index);
            //    index = word.ToLower().IndexOf("a", index + 1);
            //}
        }
    }
}
