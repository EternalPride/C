using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 静态成员
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1 t = new Test1();
            Test1 t2 = new Test1();
            Test1 t3 = new Test1();
            Console.WriteLine("{0}", Test1.x);
            Console.WriteLine("{0}", t3.y);
        }
    }
}
