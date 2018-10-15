using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double add(double a, double b)
        {
            double i;
            i= a + b;
            Console.WriteLine("{0}",i);
            return i;
        }
        static int add(int a,int b)
        {
            int i;
            i = a + b;
            Console.WriteLine("{0}", i);
            return i;
        }
        static string add(string a, string b)
        {
            string i;
            i = a + b;
            Console.WriteLine("{0}", i);
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("方法重载");
            int i = add(1,33 );
            double d = add(2, 3.4);
            string s = add("abc", "123");
        }

    }
}
