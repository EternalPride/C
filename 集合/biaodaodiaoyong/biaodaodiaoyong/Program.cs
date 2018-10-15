using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biaodaodiaoyong
{
    class Program
    {
        static int Add(int a, int b)
        {
            int s = a + b;
            return s;
        }
        static void Main(string[] args)
        {
            int result = Add(10, 5);
            Console.WriteLine(result);
        }
    }
}
