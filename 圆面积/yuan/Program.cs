using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yuan
{
    class Program
    { static double ymj(int r)
        {
            Console.WriteLine("圆面积：");
            double s = 3.16 * r * r;
            return s;
        }
        static double yzc(int r)
        {
            Console.WriteLine("圆周长：");
            double sc = 3.16 * r * 2;
            Console.WriteLine(sc);
            return sc;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入半径：");

            int i = Convert.ToInt32(Console.ReadLine());
            double result = ymj(i);
            Console.WriteLine(result);
            double r2 = yzc(i);


        }
    }
}
