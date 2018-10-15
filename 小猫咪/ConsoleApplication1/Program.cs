using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cat
    {
        private string name; public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Console.Write("请输入猫的名字：");
            string s = Console.ReadLine();
            c.Name = s;
            Console.WriteLine("猫的名字;{0}",c.Name);
        }
    }
}
