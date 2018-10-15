using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 猜大小
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rd = new Random();
            int r = rd.Next(1, 100);
            while (true)
            {
                Console.WriteLine("");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i > r)
                {
                    Console.WriteLine("猜大了");
                    Console.WriteLine("{0}", r);
                }
                else if (i == r)
                { Console.WriteLine("猜对了");
                    Console.WriteLine("{0}", r);
                    break;
                }
                else
                { Console.WriteLine("猜小了");
                    Console.WriteLine("{0}", r); 
                }
            }
               
            

            //郭浩然做
        }
    }
}
