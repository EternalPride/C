using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace f
{
    class Program
    {   
        static void Main(string[] args)
        {
            int[] c = { 12,14,25,13,78,19,55};
            Console.WriteLine("");
            List<int> f = new List<int>(c);
            foreach (int n in c)
            { Console.WriteLine(n )  ; }
            f.Sort();
            f.Reverse();
            foreach(int j in f)
            {
                Console.WriteLine(j);
            }


        }
    }
}
