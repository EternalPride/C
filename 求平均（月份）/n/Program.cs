using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[5];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("请输{0}",i+1);
                s[i] = Convert.ToInt32(Console.ReadLine());

            } int a = 0, b = 0, l = 0, h = 0;

            List<int> v = new List<int>();
            List<int> g = new List<int>();
            foreach (int j in s)
            {
                b += j;
            }
            a=b/5;//平均
            foreach (int j in s)
            {
                if (j >= a)
                {
                    l++;
                    v.Add(j);
                }
                else
                {
                    h++;
                    g.Add(j);
                }
            }Console.WriteLine("平均数{0}大于{1}小于{2}",a,l,h);
            Console.WriteLine("大于");
            foreach (int j in v)
            {
                Console.WriteLine(j);
            }Console.WriteLine("小于");
            foreach (int j in g)
            {
                Console.WriteLine(j);
            }

        }
    }
}
