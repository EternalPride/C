using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jx
{
    class Program
    {
        static void mj(int x, int y)
        {
            int s = x * y;
           Console.WriteLine("矩形面积：");
            Console.WriteLine("{0}", s);
            
        }
        static void zc(int x, int y)
        {
            int s = x + x + y + y;
            Console.WriteLine("矩形周长：");
            Console.WriteLine("{0}", s);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("矩形长度");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("矩形宽度");
            int k = Convert.ToInt32(Console.ReadLine());
            mj(c, k);
            zc(c, k);
        }
    }
}
