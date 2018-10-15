using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jiaohuan
{
    class Program
    {
        static void d(int a, int b)
        {
            int t = a;
            t = a;
            a = b;
            b = t;
            Console.WriteLine("a={0},b={1}",a,b);
        }
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            Console.WriteLine("a={0},b={1}", a, b);
            d(a, b);
            Console.WriteLine("a={0},b={1}",a,b);
        }
    }
}
