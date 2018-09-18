using System;

namespace PairProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpr = ConsoleUtils.ReadInt("Type in CPR number: ");

            var day = cpr / 100000000;
            var mounth = (cpr / 1000000) % 100;
            var year = CprConverter.GetYear(cpr);

            var date = new DateTime(year, mounth, day);

            Console.WriteLine("Age: " + (new DateTime((DateTime.Now - date).Ticks).Year - 1));

            Console.ReadLine();
        }
    }
}
