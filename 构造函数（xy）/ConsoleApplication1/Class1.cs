using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        private string x;
      
        private string y;
        public Class1(string a,string b)
        {
            x = a;

            y = b;
            Console.WriteLine("{0}{1}", a, b);
            //Console.WriteLine("{}{}",a);
        }
          
        public Class1()
        {
            // TODO: Complete member initialization
        }
            public string X
            {get{return x;}
                set{x=value;}
            }
            public string Y
            {
                get { return y; }
                set { y = value; }
            }
        
    }
}
