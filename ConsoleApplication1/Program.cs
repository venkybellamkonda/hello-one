using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class calculator
    {
        public static void  addition(int x,int y)
        {
            Console.WriteLine(x+y);
           // return x + y;
        }
        public static void  subtraction(int x,int y)
        {
            Console.WriteLine(x - y);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            calculator.addition(4, 5);
            calculator.addition(6, 7);
            calculator.subtraction(7, 9);


            //calculator obj = new calculator();
            //obj.addition(4, 5);
            //obj.subtraction(5, 4);
        }
    }
}
