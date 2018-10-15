using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tongxue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a;
            int s;
            Console.WriteLine("请输入同学个数;");
            s = Convert.ToInt32(Console.ReadLine());
            a = new string[s];
            for (int i = 0; i <=a.Length; i++)
            {
                Console.WriteLine("同学{0}", i + 1);


                a[i] =(Console.ReadLine());

            }
            Console.WriteLine("同学是");
            int index = 0;

            foreach (string num in a)
                Console.WriteLine("a[{0}]={1}", index, num);
            index++;
            
            
        }
    }
}
