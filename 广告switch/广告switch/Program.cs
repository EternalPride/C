using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 广告switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("只能A或B");
            string x = Console.ReadLine();
            Console.WriteLine("输入广告输出的时长");
            int F = Convert.ToInt32(Console.ReadLine());
            if (x == "A")//地段A
            {
                switch (F / 5)
                {
                    case 0:


                        int s = 300 * 365;
                        Console.WriteLine("{0}", s);
                        break;


                    case 1:

                        int j = 400 * 365;
                        Console.WriteLine("{0}", j);
                        break;
                    case 2:

                        int i = 500 * 365;
                        Console.WriteLine("{0}", i);
                        break;


                    case 3:
                    case 4:
                    case 5:

                        int p = 600 * 365;
                        Console.WriteLine("{0}", p);
                        break;
                    default:
                        Console.WriteLine("出错");
                        break;


                }
            }

            else if (x == "B")//时段b
            {
                switch (F / 5)
                {
                    case 0:


                        int s = 200 * 365;
                        Console.WriteLine("{0}", s);
                        break;


                    case 1:

                        int j = 300 * 365;
                        Console.WriteLine("{0}", j);
                        break;
                    case 2:

                        int i = 400 * 365;
                        Console.WriteLine("{0}", i);
                        break;


                    case 3:
                    case 4:
                    case 5:

                        int p = 500 * 365;
                        Console.WriteLine("{0}", p);
                        break;
                    default:
                        Console.WriteLine("出错");
                        break;


                }


            }
        }
    }
}
