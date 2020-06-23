using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class program8
    {
        static void Main()
        {
            Console.WriteLine("Enter your number:");
            int n= int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial is {0}",fact);
            Console.ReadKey();

        }
    }
}
