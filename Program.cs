using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();

            Console.WriteLine("Program FizzBuzz, który sprawdza czy liczba jest podzielna przez: \njeżeli przez 3, wtedy wypisze Fizz, jeżeli przez 5 to Buzz, a jeśli przez 15 to FizzBuzz");

            while (true)
            {
                Console.WriteLine("Podaj liczbę: ");
                var userNumber = NumberChecked();

                Console.WriteLine(fizzBuzz.GetNumber(userNumber));
                continue;
            }

        }

        private static int NumberChecked()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var number))
                {
                    Console.WriteLine("Podana wartość nie jest liczbą całkowitą. \nSpróbuj ponownie \nPodajliczbę: ");
                    continue;
                }

                return number;

            }

        }
    }
}
