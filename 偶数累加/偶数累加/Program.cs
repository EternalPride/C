using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 偶数累加
{
    class Program
    {
        static void Main(string[] args)
        {


            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                if (i % 2 == 0)
                    sum += i;
                i++;
            }
            Console.WriteLine("{0}", sum);


        }
    }
}
