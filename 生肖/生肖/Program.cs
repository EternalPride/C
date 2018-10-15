using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 生肖
{
    class Program
    {
        static void Main(string[] args)
        {int a =0; //郭浩然写
       
            Console.WriteLine("");
            int i = Convert.ToInt32(Console.ReadLine());
            switch ((i - a) % 12)
            {
                case 0:
                    Console.WriteLine("申猴");
                    break;

                case 1:
                    Console.WriteLine("酉鸡");
                    break;
                case 2:
                    Console.WriteLine("戌狗");
                    break;
                case 3:
                    Console.WriteLine("亥猪");
                    break;

                case 4:
                         Console.WriteLine("子鼠");
                    break;


                case 5:
                    Console.WriteLine("丑牛");
                    break;

                   
                case 6:
                    Console.WriteLine("寅虎");
                    break;

                case 7:
                    Console.WriteLine("卯兔");
                    break;


                case 8:
                    Console.WriteLine("辰龙");
                    break;

                    Console.WriteLine("巳蛇");
                    break;
                case 9:
                    Console.WriteLine("巳蛇");
                    Console.WriteLine("");
                    break;

                case 10:
                    Console.WriteLine("午马");
                    break;


                case 11:
                    Console.WriteLine("未羊");
                    break;


            }











        }
    }
}
