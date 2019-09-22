using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int menuOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("4.Exit");
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2.Odejmowanie");
                Console.WriteLine("3.mnoznik");

                if (menuOption == 4)
                {
                    break;
                }
            }
               }
    }
}
