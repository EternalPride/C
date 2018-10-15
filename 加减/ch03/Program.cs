using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch03
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("输入你的名字;");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}！", userName);
            Console.WriteLine("现在给我一个数:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("现在给我另一个数：");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the sum of{0} and {1} is {2}.", firstNumber,secondNumber, firstNumber + secondNumber);
                
            Console.WriteLine(" the result of subtracting{0}from {1}is{2}.", secondNumber, firstNumber, firstNumber - secondNumber);
            Console.WriteLine("the product of {0} and {1}is{2}.",firstNumber,secondNumber,firstNumber*secondNumber);
            Console.WriteLine("the result of dividing {0}by {1}is{2}.", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("the remainder after diving{0}by {1}is {2}.", firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();
        }
    }
}
