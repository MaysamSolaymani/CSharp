using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    class Day_01
    {
        public Day_01()
        { 

        }

        public  void Numbers()
        {
            Console.WriteLine("addition 2 and 3 is: " + (2 + 3));                 // addition(+)
            Console.WriteLine("subtraction 3 and 1 is: " + (3 - 1));              // subtraction(-)
            Console.WriteLine("multiplication 2 and 3 is: " + (2 * 3));           // multiplication(*)
            Console.WriteLine("division 2 and 3 is: " + (3 / 2));                 // division(/)
            Console.WriteLine("exponential 2 and 3 is: " + (Math.Pow(3, 2)));     // exponential
            Console.WriteLine("-------------------------------------------------");
            int num_a = 5;
            int num_b = 7;
            double num_c = 2.38;
            double num_d = 3.79;
            Console.WriteLine("addition 5 and 7 is: " + (num_a + num_b));
            Console.WriteLine("addition 2.38 and 3.79 is: " + (num_c + num_d));
            Console.WriteLine("addition 5 and 2.38 is: " + (num_a + num_c));
            Console.WriteLine("----------------------");
            Console.WriteLine(num_a++); //write before addition
            Console.WriteLine(++num_a); //write after addition
            Console.WriteLine("----------------------");
            Console.WriteLine(num_c--); //write before subtraction
            Console.WriteLine(--num_c); //write after subtraction
            Console.WriteLine("----------------------");
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.Sin(0));
            Console.WriteLine(Math.Cos(0));
        }
    }
}
