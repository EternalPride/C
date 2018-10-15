using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 广告__if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("只能A活B");
            string x = Console.ReadLine();
            Console.WriteLine("输入广告输出的时长");
            int F = Convert.ToInt32(Console.ReadLine());
            if (x == "A")
            {
                if (F < 5)
                {
                    int s = 300 * 365;
                    Console.WriteLine("{0}", s);
                }

                else if (F > 5 & F < 10)
                {
                    int s = 400 * 365;
                    Console.WriteLine("{0}", s);
                }





                else if (F > 10 & F < 15)
                {
                    int s = 500 * 365;
                    Console.WriteLine("{0}", s);
                }

                else if (F > 15 & F < 30)
                {
                    int s = 600 * 365;
                    Console.WriteLine("{0}", s);
                }

                else if (x == "B")//时段b
                {
                    if (F < 5)
                    {
                        int s = 200 * 365;
                        Console.WriteLine("{0}", s);
                    }

                    else if (F > 5 & F < 10)
                    {
                        int s = 300 * 365;
                        Console.WriteLine("{0}", s);
                    }





                    else if (F > 10 & F < 15)
                    {
                        int s = 400 * 365;
                        Console.WriteLine("{0}", s);
                    }

                    else if (F > 15 & F < 30)
                    {
                        int s = 500 * 365;
                        Console.WriteLine("{0}", s);
                    }








                }

            }
        }
    }
}
