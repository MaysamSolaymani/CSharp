using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
	class Person
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
    }
	
    class Car
    {
        public string color;
        public int maxSpeed;
        public string model;
        public int year;
		
        public Car() { }

        public Car(string modelName, string modelColor, int modelYear, int ModelSpeed)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
            maxSpeed = ModelSpeed;
        }
        
        public void Max_Speed()  
        {
            Console.WriteLine("The fast as it can is: " + maxSpeed.ToString());
        } 

    }
}
