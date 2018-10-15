using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] qw = { 14.5, 17.9, 22.1, 25.5, 27.6, 28.6, 28.4, 27.1, 24.2, 19.6, 15.3 };
            double p, zui, x;
            count(out zui, out x, out p, qw);
            
            
            Console.WriteLine("平均{0}  最大{1}  最小{2}", p, zui, x);


        }
        static void count (out double zui,out double x,out double p,params double[]qw)
        {
            double sum = 0;
            zui = x = p = 0;
            Array.Sort(qw); 
            foreach (int a in qw)
            {
                sum = +a;
            
            }
            p = sum / 12;
            x = qw[0];
            zui = qw[qw.Length - 1];
           
        }
    }
}
