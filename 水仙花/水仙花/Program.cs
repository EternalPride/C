using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 水仙花
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=100;
            while(a<1000)
            {
                a++;
                int d = a / 100;
                int n = (a - 100 * d) / 10;
                int g = a-(a / 10) * 10;

                if (a == d * d * d + n * n * n + g * g * g)
                    Console.WriteLine("{0}",a);
            //郭浩然做
            }
        }
    }
}
