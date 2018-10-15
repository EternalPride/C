using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tom
{public delegate void tou();
    class jerry
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age= value; }
        }
        public jerry() 
        {
        }
        public jerry(string n, int a)
        {
            Console.WriteLine("名字{0}",n);
            name = n;
            Console.WriteLine("年龄{0}",a);
            age = a;


        }
        public event tou steaevent;
        public void steal()
        {
            Console.WriteLine("{0}去偷东西。", name); Thread.Sleep(1000);
            if (steaevent != null)
            {
                steaevent();
            }
        }
        //public event tou run;
        public void run()
        {
            Console.WriteLine("{0}逃跑", name); Thread.Sleep(1000);
   }
    class cat 
    { private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age= value; }
        }
        public cat() 
        {
        }
        public cat(string n, int a)
        {
            Console.WriteLine("名字{0}",n);
            name = n;
            Console.WriteLine("年龄{0}",a);
            age = a;


        } 
        //public event tou zui;
        public void z()
        {
            Console.WriteLine("{0}去捉老鼠", name);
            Thread.Sleep(1000);
            //Console.ReadKey();

        }
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            jerry h = new jerry("jerry", 2);
            //h.Name = "杰瑞";
            //h.Age = 2;
            cat g = new cat("tom", 2);
            h.steaevent += g.z;

            h.steal(); h.run();

            Console.ReadKey();
        }
    }
    }
}
