using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单行调用
{
    class Program
    {
        static void Add(int x, int y)
        {
            int s = x + y;
            Console.WriteLine("{0}", s);
        }
        static void Main(string[] args)
        {
            Add(10, 56);
        }
    }
}
