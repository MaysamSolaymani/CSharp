using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{

        public class Vehicle  //parent
        {
            public string brand = "Ford";  // Vehicle field
            public void honk()             // Vehicle method 
            {
                Console.WriteLine("Tuut, tuut!");
            }

            public Vehicle() { }
        }

        public class NewCar : Vehicle  // derived class (child)
        {
            public string modelName = "Mustang";  // Car field
        }



}
