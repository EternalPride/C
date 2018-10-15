using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MY_APP7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, s, d;
            Console.WriteLine("换20");
            for (a = 1; a < 14; a++)
            {
                for (s = 1; s < 8; s++)
                {
                    for (d = 1; d < 4; d++)
                    {
                        if (a + 2 * s + 5 * d == 20)
                            Console.WriteLine("一元{0}二元  {1} 五元 {2}  ", a, s, d);


                    }
                }
            }

        }
    }
}
