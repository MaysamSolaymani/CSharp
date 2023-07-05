using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    class Day_03
    {
        public Day_03()
        {
        }

        public void Print()
        {
            Console.WriteLine("This is a Method without any parameters!");
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public double Pow(double X, double Y)
        {
            return Math.Pow(X,Y);
        }

        public string CallFunc(double X, double Y, string text)
        {
            return string.Format(text, X, Y, Pow(X, Y));
        }

    }
}
