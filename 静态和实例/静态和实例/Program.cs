using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 静态和实例
{
    class Program
    {
        static void Main(string[] args)
        {StaticOutClass t=new StaticOutClass();
        t.x = 2;
        t.y = 1;
        t.F();
        t.G();
        StaticOutClass.x = 1;
        StaticOutClass.y = 1;
        StaticOutClass.G();
        StaticOutClass.F();
        }
    }
}
