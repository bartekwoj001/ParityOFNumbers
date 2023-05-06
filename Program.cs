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
            Console.WriteLine("Podaj liczbę do sprawdzenia czy jest parzysta. Żeby zakończyć wybierz 't'");

            while (true)
            {
                
                var number = GetNumber();

                if (number % 2 == 0)
                {
                    Console.WriteLine("\nLICZBA PARZYSTA");
                }
                else
                {
                    Console.WriteLine("\nLICZBA NIEPARZYSTA");
                }
                Console.WriteLine("Podaj kolejną liczbę. Żeby zakończyć wybierz 't'");
            }

        }

        private static int GetNumber()
        {
           while (true)
            {
                var value = Console.ReadLine();
                if(value.ToUpper() == "T")
                    Environment.Exit(0);


                if (!int.TryParse(value, out int number))
                {
                    Console.WriteLine("Podano nieprawidłową wartość, spróbuj ponownie");
                    continue;
                }
                return number;
            }
        }
    }
}
