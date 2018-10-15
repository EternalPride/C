using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace guohaoran
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int r = rd.Next(1, 100);
            Console.WriteLine("");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i > r)
                Console.WriteLine("猜大了");
            else if (i == r)
                Console.WriteLine("猜对了");
            else
                Console.WriteLine("猜小了");
            Console.WriteLine("{0}",r);

            //郭浩然做


        }
    }
}
