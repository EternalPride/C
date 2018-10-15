using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MY_APP8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, d;
            Console.WriteLine("1000素数；");
            for (a = 1; a <100; a++) 
            {
                for (d = 2; d < a; d++)
                {
                    if (a % d == 0)
                    {
                        break; 
                    }
                

            } if (a == d)
                { Console.Write("{0}   ", a); }
            }
        }
    }
}
