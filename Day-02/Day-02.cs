using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Day_02
{
    class Day_02
    {
        public Day_02()
        {
        }

        public void Casting()
        {
            //Implicit Casting (automatically) - converting a smaller type to a larger type size
            //char -> int -> long -> float -> double
            //Explicit Casting (manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char
            int myInt = 9;
            double myDouble = myInt; // Automatic casting: int to double
            myDouble = 9.78;
            myInt = (int)myDouble;    // Manual casting: double to int
            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9
            myInt = 10;
            myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }

        public void Boolians()
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y); // returns True, because 10 is higher than 9
            Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9
            x = 9;
            Console.WriteLine(x == 9); // returns True, because the value of x is equal to 10
            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

            int myAge = 25;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);
            if (myAge >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }
        }

        public void Conditions()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            //Short Hand If...Else
            time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            //******************************************************

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

        }

        public void Looping()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //--------------------------------------
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
            //--------------------------------------
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            for (i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            //--------------------------------------
            // Outer loop
            for (i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }
            //--------------------------------------
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string str in cars)
            {
                Console.WriteLine(str);
            }

        }

        public void Break_and_Continue() 
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            int _i = 0;
            while (_i < 10)
            {
                Console.WriteLine(_i);
                _i++;
                if (_i == 4)
                {
                    break;
                }
            }

            _i = 0;
            while (_i < 10)
            {
                if (_i == 4)
                {
                    _i++;
                    continue;
                }
                Console.WriteLine(_i);
                _i++;
            }
        }

        public void Arrays()
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            // Now outputs Opel instead of Volvo

            string[] _cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(_cars.Length);
            // Outputs 4

            // Create an array of four elements, and add values later
            //string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Outputs 2
            numbers[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }  
        }
    }
}
