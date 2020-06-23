using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class program17
    {
        static void Main()
        {
            string revs = "";
            Console.WriteLine(" Enter string");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            Console.WriteLine("After reverse  " + revs);
            Console.ReadKey();
        }
    }
}
