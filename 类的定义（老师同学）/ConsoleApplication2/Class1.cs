using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Class1
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string xue;
        public string Xue 
        {
            get { return xue; }
            set { xue = value; }
        } private string xing;
        public string Xing
        {
            get { return xing; }
            set { xing = value; }
        }
        private string ceng;
        public string Ceng
        {
            get { return ceng; }
            set { ceng = value; }
        }
        public void study()
        { Console.WriteLine("学生在听课"); }


    }
}
