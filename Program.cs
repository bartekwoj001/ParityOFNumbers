using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParityOFNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę do sprawdzenia czy jest parzysta:");
            var number = GetNumber();

            if (number % 2 == 0)
            {
                Console.WriteLine("\nLICZBA PARZYSTA");
            }
            else
            {
                Console.WriteLine("\nLICZBA NIEPARZYSTA");
            }

        }

        private static int GetNumber()
        {
           while (true)
            {
                if (!int.TryParse(Console.ReadLine(),out int number))
                {
                    Console.WriteLine("Podano nieprawidłową wartość, spróbuj ponownie");
                    continue;
                }
                return number;
            }
        }
    }
}
