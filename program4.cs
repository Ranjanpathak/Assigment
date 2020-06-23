using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class program4
    {
        static void Main(string[] args)
        {

            Console.Write("Input an integer : ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
                Console.WriteLine("{0} is an even integer.\n", num1);
            else
                Console.WriteLine("{0} is an odd integer.\n", num1);
            Console.ReadKey();
        }
    }
}
