using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            t c = new t();
            c[3] = 17.3;
            c[5] = 21.1;
            Console.WriteLine(c[3]); Console.WriteLine(c[5]);
            for (int i = 0; i <9; i++)
            {
                Console.WriteLine("{0}", c[i]);
            }
        }
    }
}
