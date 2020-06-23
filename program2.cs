using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class program2
    {
        static void Main(string[] args)
        {


            foreach (Object obj in args)
            {
                Console.WriteLine("Hi" + obj + " Welcome to the C# world");
                Console.ReadKey();
            }

        }
    }
}
