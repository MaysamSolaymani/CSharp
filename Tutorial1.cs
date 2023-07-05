using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    enum WeekDays
    {
        Monday,     // 0
        Tuesday,    // 1
        Wednesday,  // 2
        Thursday,   // 3
        Friday,     // 4
        Saturday,   // 5
        Sunday      // 6
    }

    enum Categories
    {
        Electronics,    // 0
        Food,           // 1
        Automotive = 6, // 6
        Arts,           // 7
        BeautyCare,     // 8
        Fashion         // 9
    }

    enum NewCategories
    {
        Electronics = 1,
        Food = 5,
        Automotive = 6,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15,
        WomanFashion = 15
    }
    struct Coordinate
    {
        private int _x, _y;

        public int x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
                CoordinatesChanged(_x);
            }
        }

        public int y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
                CoordinatesChanged(_y);
            }
        }

        public event Action<int> CoordinatesChanged;
    }
    class Day_01
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int age { get; set; }
        }
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
        
        public void Strings()
        {
            string myString = "Hello Maysam, say hi to the World!";
            Console.WriteLine(myString);
            Console.WriteLine(myString.Length);
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.Replace("hi","HELLO"));
            Console.WriteLine(myString.Remove(0, 6));
            string[] myStringArray = myString.Split(' ');
            Console.WriteLine("#########################");    
            foreach (var item in myStringArray)
            {
                Console.WriteLine(item);    
            }
            string A = "First string";
            string B = "Second string";
            string C = "!";
            Console.WriteLine(A + " " + B + C);
            Console.WriteLine(string.Concat(A, " ", B, C));
            string all = string.Concat(A, " ", B, C);
            if (all.IndexOf("z") != -1)
                Console.WriteLine("Exist");
            else
                Console.WriteLine("Not Exist");

            char[] cha = all.Trim().ToLower().ToCharArray();
            Array.Sort(cha);
            Console.WriteLine(cha);

            char[] newString = all.ToCharArray();
            Array.Reverse(newString);
            all = String.Join("", newString);
            Console.WriteLine(all);
        }

        public void Datetimes()
        {
            Console.WriteLine(new DateTime(2023, 07, 03, 5, 10, 20));
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine(DateTime.MinValue);
            var str = "99/99/9999";
            DateTime dt;
            
            var isValidDate = DateTime.TryParse(str, out dt);

            if(isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine("is not a valid date string");

            var mydate = new DateTime(2023, 07, 03, 23, 58, 30, 999);
            mydate.ToString("MM/dd/yy"); // 07/3/23
            mydate.ToString("MM/dd/yyyy");//07/03/2023
            mydate.ToString("dd/MM/yy");//03/07/23
            mydate.ToString("dd-MM-yy");//03-07-23
            mydate.ToString("ddd, dd MMM yyyy"); // Mon, 03 Aug 2023
            mydate.ToString("dddd, dd MMMM yy"); // Monday, 03 July 23
            mydate.ToString("dddd, dd MMMM yyyy HH:mm"); // Monday, 03 July 2023 23:58
            mydate.ToString("MM/dd/yy HH:mm"); // 07/03/23 23:58
            mydate.ToString("MM/dd/yyyy hh:mm tt"); // 07/03/2023 11:58 PM
            mydate.ToString("MM/dd/yyyy H:mm t"); // Mon, 03 Aug 2023 P
            mydate.ToString("MM/dd/yyyy H:mm:ss"); // 07/03/2023 23:58:30
            mydate.ToString("MMM dd"); // Aug 03
            mydate.ToString("MM-dd-yyyTHH:mm:ss.fff"); // 07-03-2023T23:58:30.999
            mydate.ToString("MM-dd-yyy g"); // 07-03-2023 A.D.
            mydate.ToString("HH:mm"); // 23:58
            mydate.ToString("hh:mm tt"); // 11:58 PM
            mydate.ToString("HH:mm:ss"); // 23:58:30
            mydate.ToString("'Full DateTime:' MM-dd-yyyTHH:mm:ss"); // Full DateTime: 07-03-2023T23:58:30

            var prevDate = new DateTime(2021, 7, 15); //15 July 2021
            var today = DateTime.Now;
            //get difference of two dates
            var diffOfDates = today - prevDate;
            Console.WriteLine("Difference in Timespan: {0}", diffOfDates);
            Console.WriteLine("Difference in Days: {0}", diffOfDates.Days);



            DateTime dt1 = new DateTime(2023, 4, 11, 4, 0, 12); //11 May 2020 4:00:12
            DateTime dt2 = new DateTime(2023, 5, 11, 5, 20, 28); //11 June 2020 5:20:28
            DateTime dt3 = new DateTime(2023, 6, 11); //11 July 2020 0:00:00
            TimeSpan interval = new TimeSpan(2, 14, 18); // 02:14:15
            TimeSpan diff1 = dt2.Subtract(dt1); //DateTime - DateTime 
            TimeSpan diff2 = dt3.Subtract(dt2); //Date - DateTime
            DateTime diff3 = dt3.Subtract(interval); //Date - TimeSpan 
            DateTime diff4 = dt2.Subtract(interval); //DateTime - TimeSpan 
            //interval.Subtract(dt3); // error
            Console.WriteLine("{0} - {1} = {2}", dt2, dt1, diff1);
            Console.WriteLine("{0} - {1} = {2}", dt3, dt2, diff2);
            Console.WriteLine("{0} - {1} = {2}", dt3, interval, diff3);
            Console.WriteLine("{0} - {1} = {2}", dt2, interval, diff4);


        }

        public void Structs()
        {
            Coordinate point = new Coordinate();
            point.CoordinatesChanged += StructEventHandler;
            point.x = 10;
            point.y = 20;
        }

        public void Enums()
        {
            Console.WriteLine((int)WeekDays.Monday); 
            Console.WriteLine(WeekDays.Monday); // Monday
            var wd = (WeekDays) 5; // int to enum conversion
            Console.WriteLine(wd);
        }

        public void AnonymousType()
        {
            var _student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(_student.Id); //output: 1
            Console.WriteLine(_student.FirstName); //output: James
            Console.WriteLine(_student.LastName); //output: Bond
            var _Student = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };
            Console.WriteLine(_Student.Address.City);
            IList<Student> studentList = new List<Student>() { 
            new Student() { StudentID = 1, StudentName = "John", age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student() { StudentID = 5, StudentName = "Ron" , age = 21 } 
        };

            var students = from s in studentList
                           select new { Id = s.StudentID, Name = s.StudentName };

            foreach (var stud in students)
                Console.WriteLine(stud.Id + "-" + stud.Name);

        }

        public void DynamicType()
        {
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
        }
        static void StructEventHandler(int point)
        {
            Console.WriteLine("Coordinate changed to {0}", point);
        }
    }
}
