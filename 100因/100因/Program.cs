using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _100因
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}的因子", i);//郭浩然
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)

                        Console.Write("{0}  ", j);

                }

               Console.WriteLine();
            }

        }
            
        
    }
}
