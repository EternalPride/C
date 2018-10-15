using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MY_APP
{
    class Program
    {
        static void Main(string[] args)     
        
        {
            int a, b, c;
            Console.WriteLine("1000完数；");
            for (a = 1; a <= 1000; a++)
            {
                c = 0;
                for (b = 1; b <= a / 2; b++)
                {
                    if (a % b == 0)
                    {
                        c += b;
                    }



                } if (c == a) 
                { Console.WriteLine("{0}", c); }
            }

           

        }
    }
}
