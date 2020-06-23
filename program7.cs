using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class program7
    {
        static void Main()
        {
            int a = 0;
            int s = 0;
            while (s <625)
            {
                s = a * a;
                a++;
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
