using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class program3
    {

        public static void Main(String[] ar)
        {


            int x = Int32.Parse(ar[0]);
            int y = Int32.Parse(ar[1]);

            for (int i = x; i < y; i++)
            {
                Console.WriteLine(i);
                Console.ReadKey();

            }

        }
    }
}
