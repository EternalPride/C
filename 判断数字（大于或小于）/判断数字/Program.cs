using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 判断数字
{
    class Program
    {
        static void Main(string[] args)
        {
            bool v = false;
            double v1, v2;
            v1 = 0;
            v2 = 0;
            while (!v)
            {
                Console.WriteLine("输入1");
                v1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入2");
                v2 = Convert.ToDouble(Console.ReadLine());
                if ((v1 > 10)^(v2 > 10))
                {
                    v = true;

                }
                else
                {
                    if ((v1 <= 10) && (v2 <= 10))
                    {
                        v = true;

                    }
                    else { Console.WriteLine("错了再次输入："); 
                    }
                }
            }  Console.WriteLine("{0}和{1}   {2}",v1,v2,v);

            }
    }
}
