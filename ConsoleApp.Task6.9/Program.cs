using System;

namespace ConsoleApp.Task6._9
{
    internal class Program
    {
        /*9)  Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?*/
        static void Main(string[] args)
        {
            Console.Write("Metni yazin: ");
            string word = Console.ReadLine();
            //string word = "azerbaycaneza";
            word = word.ToLower();
            string first3symols = word.Substring(0, 3);
            string last3symbols = word.Substring(word.Length - 3, 3);

            string lastRev3symbols = "";

            for (int i = last3symbols.Length - 1; i >= 0; i--)
            {
                lastRev3symbols = lastRev3symbols + last3symbols[i];
            }

            Console.WriteLine($"ilk 3 simvol: {first3symols}");
            Console.WriteLine($"son 3 simvol: {last3symbols}");
            Console.WriteLine($"son 3 simvolun tersi: {lastRev3symbols}");

            if (first3symols == lastRev3symbols)
            {
                Console.WriteLine("Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdir.");
            }
            else
            {
                Console.WriteLine("Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraber deyil.");
            }

        }
    }
}
