using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Pierwiastek");


                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 0)
                {
                    break;
                }

            }
        }
    }
}
