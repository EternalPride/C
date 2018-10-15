using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _冒泡
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 77, 9, 18, 43, 35, 27, 27, 62, 84, 99, 57 };
            int temp;
            for (int i = 0; i < num.Length;i++ )
            {
                for (int j = 0; j < num.Length - i - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
        }
    }
}
