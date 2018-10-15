using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();//学
            Class2 f = new Class2(); //老
            Console.WriteLine("enter your number");
            string s = Console.ReadLine();
            c.Name = s;
            string v = Console.ReadLine();
            f.Name = v;
            Console.WriteLine("enter your name");
            string j = Console.ReadLine();
            c.Name = j; string l = Console.ReadLine();
            f.Name = l; Console.WriteLine("enter your sex");
            string lk = Console.ReadLine();
            c.Name = lk;
            string jk = Console.ReadLine();
            f.Name = jk;
            Console.WriteLine("enter your 职称");
            string hj = Console.ReadLine();
            c.Name = hj; string lui = Console.ReadLine();
            f.Name = lui;
            c.study();
            f.Teach();
            Console.WriteLine("学生学号：{0}    姓名：{1}    性别：{2}   成绩属性：{3}", s,j,lk, hj);
            Console.WriteLine("老师编号：{0}    姓名：{1}    性别：{2}   职称属性：{3}",v, l, jk, lui);
        }
    }
}
