using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            while (i <= 10)
            {
                if (i == 6)
                    goto exitPoint;
                Console.WriteLine("{0}", i++);
            }
            Console.WriteLine("永远不会到达此代码。");
            exitPoint:
            Console.WriteLine("使用goto退出循环时运行代码");
           
        }
    }
}
