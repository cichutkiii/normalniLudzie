using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2.Odejmowanie");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if(menuOption == 0)
                {
                    break;
                }
            }
               }
    }
}
