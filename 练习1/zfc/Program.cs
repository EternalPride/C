using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zfc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string s = "hello . world";

            //Console.WriteLine(s.Length);
            //string s1 = "Hello   World";
            //string s2 = "hello  world";
            //bool result = (s1 == s2);
            //Console.WriteLine(result);
            //bool r = s1.Equals(s2);
            //Console.WriteLine(r);
            //bool re1 = s1.StartsWith("Hello");
            //bool re2 = s1.EndsWith("World");
            //Console.WriteLine(re1);
            //Console.WriteLine(re2);
            //int jh = s.IndexOf('d');
            //int j = s.IndexOf("ld");
            //int k = s.LastIndexOf('o');
            //Console.WriteLine(k);
            //char[] c = new char[] { 'o', 'l', 'o' };
            //int o = s.LastIndexOfAny(c);
            //Console.WriteLine(o);
            //char v = s[8];
            //Console.WriteLine(v);
            //string s3 = s1;
            //Console.WriteLine(s3);
            //string d1 = "asd@ty.ty";
            //string d2 = d1.Substring(3,2);
            //Console.WriteLine(d2);
            //string d3 = "hgijhh ngh";
            //string d = d3 + d1;
            //Console.WriteLine(d);
            //string s1 = "fydgfg@ghf.ghh";
            //char[] c= new char[]{ '.','@' };
            //string[] s2= s1.Split(c);
            //foreach (string g in s2)
            //{
            //    Console.WriteLine(g);
            //}

            //string separator = "/";
            //string s = String.Join(separator, s2);
            //Console.WriteLine(s);
            string s1 = "    Hello World   ";
            //string s2 = s1.Insert(2, ".,");
            //string s3=s1.Replace("llo","SFVD");
            //Console.WriteLine("{0}    {1}", s2, s3);
            //Console.Write("eqeer;");
            //int f=Console.Read();
            //Console.Write(""+f);
            string s2 = s1.Remove(2);
            string s3 = s1.Remove(3, 2);
            Console.WriteLine("{0}    {1}  ",s2,s3);
            string s4 = s1.Trim();
            int g1 = s1.Length;
            int g2 = s4.Length;
            Console.WriteLine("{0}     {1}",g1,g2);
            string s5 = s1.ToLower();
            Console.WriteLine(s5);
            string s6 = s1.ToUpper();
            Console.WriteLine(s6);

        }
    }
}
