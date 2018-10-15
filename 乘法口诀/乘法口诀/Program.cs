using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 乘法口诀
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (int d = 1; d <= 9; d++)
            {
                for (int s = 1; s <= d; s++) 
                {
                    num = d * s;
                    Console.Write("{0}x{1}={2} ", d, s, num);
                
                
                }

                Console.Write("\r\n");//郭浩然写
            
            }



        }
    }
}
