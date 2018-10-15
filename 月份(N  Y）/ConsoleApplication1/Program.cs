using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MY APP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] yue = new string[12] { "jan", "feb", "mar", "apr", "may", "june", "july", "aug", "sep", "oct", "nov", "dece" };


            while (true)
            {
                Console.WriteLine("输入一个月份：");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(yue[a - 1]);
            Console.WriteLine("暂停N,继续Y");
            string c = Console.ReadLine();
            if (c == "N")
                break;
            else if (c == "Y")
                continue;
        }
            
        }
    }
}
