using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    class Program
    {
        public static void Numbers()
        {
            Console.WriteLine("subtraction 2 and 3 is: " + (2 + 3));   // addition(+)
            Console.WriteLine("subtraction 3 and 1 is: " + (3 - 1));   // subtraction(-)
            Console.WriteLine("multiplication 2 and 3 is: " + (2 * 3));   // multiplication(*)
            Console.WriteLine("division 2 and 3 is: " + (3 / 2));   // division(/)
            Console.WriteLine("exponential 2 and 3 is: " + (Math.Pow(3, 2)));  // exponential

        }
        static void Main(string[] args)
        {
            // write a text in console
            Console.Write("Maysam, Say Hello to the World!");
            //call function
            Numbers();
            //wait for exit
            Console.ReadKey();
        }
    }
}
