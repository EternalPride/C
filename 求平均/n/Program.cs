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
                }
                else
                {
                    h++;
                }
            }Console.WriteLine("平均数{0}大于{1}小于{2}",a,l,h);
            List<int> x = new List<int>(s);
            x.Add(a);
            foreach (int j in s)
            {
                Console.WriteLine();
            }

        }
    }
}
