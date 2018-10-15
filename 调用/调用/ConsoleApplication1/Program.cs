using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
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
            Console.WriteLine("{0}", Add(10, 5));
        }
    }
}
