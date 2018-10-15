using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{   public delegate void e();
    class c
    {
        private int time;
        public event e g;
       public void r()
        {
            Console.WriteLine("闹钟响了。。");
        for(int i=0;i<=10;i++)
        {
            Console.WriteLine("{0}声", i);
            System.Threading.Thread.Sleep(100);

        }
        if (g != null)
        {
            g();
        }
       }

    }
    class s
    {
        public void ge()
        {
            Console.WriteLine("起床。。。。");
        }
        public void sl()
        {
            Console.WriteLine("睡觉");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            c b = new c();
            s c = new s();
            b.g += c.ge;
            //b.g += c.sl;
            b.r();
        }
    }
}
