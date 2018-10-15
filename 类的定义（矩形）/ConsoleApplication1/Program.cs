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
            Rectangle c = new Rectangle();
            c.Cang = 12;
            c.Kuan = 152;
            double s = c.Arae();
            Console.WriteLine("{0}", s);
        }
    }
}
