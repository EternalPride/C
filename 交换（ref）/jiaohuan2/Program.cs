using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jiaohuan2
{
    class Program
    {
        static void d( ref int a,ref int b)
        {
            int t = a;
            t = a;
            a = b;
            b = t;
            Console.WriteLine("a={0},b={1}", a, b);
        }
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            Console.WriteLine("a={0},b={1}", a, b);
            d(ref a,ref b);
            Console.WriteLine("a={0},b={1}", a, b);
        }
        
    }
}
