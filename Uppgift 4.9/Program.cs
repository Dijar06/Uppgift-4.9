using System;

namespace Uppgift4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm sidlängd för en triangel");
            int längd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= längd; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}