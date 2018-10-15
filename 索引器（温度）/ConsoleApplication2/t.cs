using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class t
    {
        double[] temps = new double[10] { 13.2, 14.7, 15.5, 16.9, 18.8, 21.3, 19.9, 18.1, 17.2, 15.5 };
        public double this[int i]
        {
            get { return temps[i]; }
            set { temps[i] = value; }
        }
    }
}
