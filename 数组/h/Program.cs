using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace h
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int x; Console.WriteLine("gfd");
            x = Convert.ToInt32(Console.ReadLine());
            a = new int[x];
            for (int i = 0; i < a.Length; i++) 
            {Console.WriteLine("{0}",i+2);
            a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("jj");
            int h=0;
            foreach (int f in a)
            {
                Console.WriteLine("[{0}]={1}", h, f);
                h++;
            }

        }
    }
}
