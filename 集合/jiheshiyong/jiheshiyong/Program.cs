using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jiheshiyong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("最开始数字：");
            int[] array = { 21,25,54,55,55,5484,5};

            List<int> f = new List<int>(array);
            foreach (int a in f)
            {
                Console.Write("{0}  ",a);
            } 

            f.Sort();
            //f.Reverse();
            Console.WriteLine("\n");
            Console.WriteLine("排序后：");
            foreach (int a in f)
            {
                Console.Write("{0}  ",a);

            } Console.WriteLine("\n");
            Console.WriteLine("位置");//wei
            int i,l;
           
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("插入数");
            l = Convert.ToInt32(Console.ReadLine());
            f.Insert(i-1, l);
            Console.WriteLine("结果");
            foreach (int a in f)
            {
                Console.Write("{0}  ", a);
            }
            f.Sort();
            //f.Reverse();
            Console.WriteLine("\n");
            Console.WriteLine("排序后：");
            foreach (int a in f)
            {
                Console.Write("{0}  ", a);

            }

        }
    }
}
