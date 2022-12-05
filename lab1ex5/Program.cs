using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        { /*Scrieti un program care citind 2 numere de la tastatura le va afisa tot timpul in ordine crescatoare */
          
            Console.WriteLine("Acesat program va ordona numerele in ordine crescatoare");

            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int y = int.Parse(Console.ReadLine());

            if (x >= y)
            {
                Console.WriteLine(y +" "+ x );
            }
            else
            {
                Console.WriteLine(x +" " + y);
            }
        }
    }
}
