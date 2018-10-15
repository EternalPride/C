using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static long t(int n)
        {
            long m;
            if (n == 1)
                m = 10;
            else
                m = t(n - 1) + 3;
            return m;

        }
        static void Main(string[] args)
        {
            int n, i;
            long m;
            Console.WriteLine("苹果问题");

            Console.Write("苹果箱数：");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("第{0}个箱子有{1}个苹果", n, t(n));

        }
    }
}
