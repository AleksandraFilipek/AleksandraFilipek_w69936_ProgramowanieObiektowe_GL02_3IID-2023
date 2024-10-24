using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace ProgramowanieObiektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            parzystosc(5);
            liczbyParzyste(10);
            Console.WriteLine(silnia(6));
            gra();

        }
        static void parzystosc(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("parzysta");
            }
            else
            {
                Console.WriteLine("nieparzysta");
            }
        }
        static void liczbyParzyste(int n)
        {
            int i = 1;
            while (i <= n)
            {
                if (i % 2 == 0) {
                    Console.WriteLine(i); 
                }
                i++;
            }
        }
        static int silnia(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * silnia(x - 1);
            }
        }
        static void gra()
        {
            var rand = new Random();
            int proba = 1;
            while (true)
            {
                Console.WriteLine("Zgadnij liczbe: ");
                var input = Console.ReadLine();
                if (int.Parse(input) == 5)
                {
                    Console.WriteLine("Zgadles");
                    Console.WriteLine("Proba: "+proba);
                    break;
                }
                else
                {
                    proba++;
                }
            }
        }
        static void menu()
        {
            while (true)
            {
                Console.WriteLine("Wybierz opcje: ");
                Console.WriteLine("1: czy jest parzysta");
                Console.WriteLine("2: lista parzystych");
                Console.WriteLine("3: silnia");
                var input = Console.ReadLine();
                if (int.Parse(input)==1)
                {

                }

            }
        }
    }
}

