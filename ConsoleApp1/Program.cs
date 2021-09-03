using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringSarasas = new string[] {"vienas", "du", "trys", "keturi" };
            foreach (var item in stringSarasas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
