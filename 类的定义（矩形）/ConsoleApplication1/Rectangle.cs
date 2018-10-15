using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Rectangle
    {
        private double cang;
        public double Cang
        {
            get { return cang; }
            set { cang = value; }

        }
        private double kuan;
        public double Kuan
        {
            get { return kuan; }
            set { kuan = value; }
        }
        public double Arae()
        {
            return Kuan * Cang;
        }
    }
}
