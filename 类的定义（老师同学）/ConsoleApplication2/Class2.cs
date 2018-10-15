using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Class2
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string bian;
        public string Bian
        {
            get { return bian; }
            set { bian = value; }
        } private string xing;
        public string Xing
        {
            get { return xing; }
            set { xing = value; }
        }
        private string zhi;
        public string Zhi
        {
            get { return zhi; }
            set { zhi = value; }
        }
        public void  Teach()
        { Console.WriteLine("老师在讲课"); }

    }
}
