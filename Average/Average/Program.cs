using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica_liczb = { 1, 2, 3, 4 };
            Console.WriteLine("podaj ilosc liczb: ");
            int n = int.Parse(Console.ReadLine());
            int[] liczby = new int[n];
            int suma = 0;
            Console.WriteLine("podaj te liczby: ");

            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = int.Parse(Console.ReadLine());
                suma += liczby[i];
            }

            Console.WriteLine("średnia liczb: ");

            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("wynosi: " + (suma / n));
            Console.ReadKey();
        }
    }
}

