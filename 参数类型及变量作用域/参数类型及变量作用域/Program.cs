using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 参数类型及变量作用域
{
    class Program
    {
        static int a = 0;
        static void Main(string[] args)
        
        {
        
            a = 5;
            int b = f( ref a);
            Console.WriteLine(a + b);
        }
        static int f( ref int x)
        {
            a = a-1;
            x = a + x;
            return a * x;
        }
    }
}
