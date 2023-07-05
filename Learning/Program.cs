using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Maysam, say hi to the World!");

            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.maxSpeed = 320;
            Ford.color = "red";
            Ford.year = 1969;
            Car Opel = new Car("Astra", "white", 2005, 270);
            Console.WriteLine(Ford.model);
            Opel.Max_Speed();

            Person myObj = new Person();
            myObj.Name = "Maysam";
            Console.WriteLine(myObj.Name);
			
            Console.ReadKey();
        }
    }
}
