using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace habit
{
    class Program
    {
        static long t(int n)
        {
            long m;
            if (n==1||n==2)
             m=1;
            else
            m=t(n-1)+t(n-2);
            return m;
        }
        static void Main(string[] args)
        {
            int n, i;
            long m;
            Console.WriteLine("兔子");
            Console.Write("月份");
            n = Convert.ToInt32(Console.ReadLine());
            m = t(n);
            Console.WriteLine("第{0}个月有{1}对兔子", n, m);
        }
    }
}
