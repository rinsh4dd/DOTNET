

//Task 1

//using System;

//class Task
//{
//    static void Main()
//    {
//        Console.Write("Enter First Number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Enter Second Number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());


//        double sum = num1 + num2;
//        double difference = num1 - num2;
//        double multiple = num1 * num2;
//        double divide = num1 / num2;

//        Console.WriteLine("THE ARITHMATIC RESULTS ARE:-");
//        Console.WriteLine("Addition : "+sum);
//        Console.WriteLine("Substraction : "+difference);
//        Console.WriteLine("Multiplication : "+multiple);
//        Console.WriteLine("Division : " + divide);
//    }
//}


//Task 2

//using System;

//class PrimeChecker
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());

//        bool isPrime = true;

//        if (number <= 1)
//        {
//            isPrime = false;
//        }
//        else
//        {

//            for (int i = 2; i <= number / 2; i++)
//            {
//                if (number % i == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//        }

//        if (isPrime)
//            Console.WriteLine($"{number} is a Prime number.");
//        else
//            Console.WriteLine($"{number} is NOT a Prime number.");

//        Console.ReadKey();
//    }
//}


//Task Day2 task1

//using System;
//class oddOrEven
//{
//static void Main()
//{

//        Console.WriteLine("Enter a number");
//        int num = Convert.ToInt32(Console.ReadLine());
//        if (num % 2 == 0)
//        {
//            Console.WriteLine("NUMBER IS EVEN");
//        }
//        else
//        {
//            Console.WriteLine("NUMBER IS ODD");
//        }

//    }
//}


//Task Day2 task2

//using System;

//class PosNegZero
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter a Number");
//        int num = Convert.ToInt32(Console.ReadLine());


//        switch (num)
//        {
//            case > 0:
//                Console.WriteLine("Number is Positive");
//                break;
//            case <0:
//                Console.WriteLine("Number is Negative");
//                break;
//            case  0:
//                Console.WriteLine("Number is zero");
//                break;
//        }

//    }
//}


//Task Day2 task3

//using System;

//class Largest
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter First Number");

//        int num1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter Second Number");
//        int num2 = Convert.ToInt32(Console.ReadLine());


//        Console.WriteLine("Enter Third Number");
//        int num3 = Convert.ToInt32(Console.ReadLine());

//        if(num1>num2 && num1 > num3)
//        {
//            Console.WriteLine($"Largest number is :{num1}");
//        }
//        else if (num2 > num1 && num2 > num3)
//        {
//            Console.WriteLine($"Largest number is :{num2}");
//        }
//        else
//        {
//            Console.WriteLine($"Largest number is :{num3}");

//        }


//    }
//}

//Task Day2 task3

//using System;
//class LeapYear
//{
//    static void Main()
//    {
//        Console.WriteLine( " Please Enter Year");
//        int year = Convert.ToInt32(Console.ReadLine());

//        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
//        {
//            Console.WriteLine("Leap Year");
//        }
//        else
//        {
//            Console.WriteLine("Not a Leap Year");
//        }

//    }

//}


//Task Day2 task4

//using System;
//class Grade
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter MARK");
//        int Mark = Convert.ToInt32(Console.ReadLine());

//        switch (Mark)
//        {
//            case int m when(m>=90&&m<=100):Console.WriteLine("S Grade");
//                break;

//            case int m when (m >= 80 && m <= 90):
//                Console.WriteLine("A Grade");
//                break;
//            case int m when (m >= 70 && m <= 80):
//                Console.WriteLine("B Grade");
//                break;
//            case int m when (m >= 60 && m <= 70):
//                Console.WriteLine("C Grade");
//                break;
//            case int m when (m >= 50 && m <= 60):
//                Console.WriteLine("D Grade");
//                break;
//            case int m when (m >= 40 && m <= 50):
//                Console.WriteLine("E Grade");
//                break;
//            case int m when (m <40):
//                Console.WriteLine("Student has Failed!!");
//                break;
//        }
//    }
//}

//Task4 DIAMOND PATTERN

//using System;

//class DiamondPattern
//{
//    static void Main()
//    {
//        int n;

//        Console.Write("Enter the number of rows (half of diamond height): ");
//        n = int.Parse(Console.ReadLine());


//        for (int i = 1; i <= n; i++)
//        {

//            for (int j = 1; j <= n - i; j++)
//                Console.Write(" ");


//            for (int j = 1; j <= 2 * i - 1; j++)
//                Console.Write("*");

//            Console.WriteLine();
//        }


//        for (int i = n - 1; i >= 1; i--)
//        {

//            for (int j = 1; j <= n - i; j++)
//                Console.Write(" ");


//            for (int j = 1; j <= 2 * i - 1; j++)
//                Console.Write("*");

//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Animal
//{
//   public string Name;
//    public int Age;

//    public void speak()
//    {
//        Console.WriteLine($"iam {Name} and iam {Age} years old. ");
//    }
//   public class Dog : Animal
//    {
//        public string breed;
//    }
//    public class Cat : Animal
//    {
//        public void Meow()
//        {
//            Console.WriteLine("Meoww!!");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Dog dog = new Dog();
//            dog.Name = "Buddy";
//            dog.Age = 10;
//            dog.breed = "Golden Retriever";
//            dog.speak();

//            Cat cat= new Cat();
//            cat.Name = "charlie";
//            cat.Age = 2;
//            cat.Meow();
//            cat.speak();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calc
//{
//    public interface IShape
//    {
//        double GetArea();
//    }
//    public class Circle : IShape
//    {
//        public double Radius;
//        public Circle(double radius)
//        {
//            Radius = radius;
//        }
//        public double GetArea()
//        {
//            return Math.PI * Radius * Radius;
//        }
//    }

//    public class Square : IShape
//    {
//        public double Side;

//        public Square(double side)
//        {
//            Side = side;
//        }

//        public double GetArea()
//        {
//            return Side * Side;
//        }
//    }

//    class Rectangle : IShape
//    {
//        public double Width;
//        public double Height;

//        public Rectangle(double width, double height)
//        {
//            Width = width;
//            Height = height;
//        }
//        public double GetArea()
//        {
//            return Width * Height;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            IShape circle = new Circle(5);
//            IShape square = new Square(4);
//            IShape rectangle = new Rectangle(10, 15);

//            Console.WriteLine($"Circle Area: {circle.GetArea()}");
//            Console.WriteLine($"Square Area: {square.GetArea()}");
//            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
//        }
//    }



//class Program
//{

//    public Program()
//    {
//        Console.WriteLine("Constructor Called");
//    }

//    static  int age;
//    string name;

//    public static void Main(string[] args)
//    {
//        Program std = new Program();
//        age = 50;
//        std.name="Rinshad"; 
//    }
//}


//class Program
//{
//    const double pi= 3.14;
//    int age;
//    string name;
//    const string country = "India";
//    public static void Main()
//    {
//        Program std = new Program();
//        std.age = 50;
//        std.name = "Rinshad";

//        Console.WriteLine($"my name is {std.name} , and im {std.age } years old!! im in{country} ");
//    }
//}

//class Program
//{
//    void greet(string name)
//    {
//        Console.WriteLine($"hai my name is {name}");
//    }
//    static void Main()
//    {
//        Program dtr = new Program();
//        dtr.greet("Rinshad");
//    }
//}                        fn with parameter


//class Program
//{
//    void greet()
//    {
//        Console.WriteLine("hai my name is Rinshad");
//    }
//    static void Main()
//    {

//        Program greet = new Program();
//        greet.greet();
//    }
//}
//}                        fn without parameter and with return type

//class Program
//{
//   public int Add (int  a,int b)
//    {
//               return a + b;
//    }
//    static void Main()
//    {
//        Program obj = new Program();

//        int result = obj.Add(100, 200);
//        Console.WriteLine(result);
//    }
//}
//instance method with parameter and return type
// function with parameter and return type



//class Program
//{
//    public static int Add(int a,int b)
//    {
//               return a + b;
//    }
//   static void Main(String[] args)
//    {
//        Console.WriteLine(Add(100, 200));
//    }
//}
//static method with parameter and return type

//class Program
//{
//    public int Square(int a)
//    {
//               return a * a;
//    }
//    static void Main(string[] args)
//    {
//        Program obj = new Program();
//        int res = obj.Square(20);

//        Console.WriteLine(res);
//    }
//}

//LINQ
using System;
//using System.Data.SqlTypes;
//  namespace Task
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };


//            var result = numbers.Where(n =>n % 2 == 0)
//                .OrderBy(n => n)
//                .Select(n=>n*n);

//           foreach(var num in result)
//            {
//                Console.WriteLine(num);
//            }
//        }
        
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<String> names = new List<string> { "Rinshad", "john","Sulaiman" };

//        var shortNames = names.Where(names =>names.Length<=8)
//           . Select(names => names.ToUpper());

//        foreach(var n in shortNames)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}


//linq with object

//using System;
//class Student
//{
//    public string Name { get; set; }
//    public int Mark { get; set; }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var students = new List<Student>
//        {
//            new Student {Name="RInshad", Mark=90},
//            new Student {Name="Kunjippa",Mark=80},
//            new Student{Name="Sulaiman",Mark=85}
//        };
//        var toppers = students
//            .Where(s => s.Mark >= 85)
//            .OrderByDescending(s => s.Mark)
//            .Select(s => s.Name);
//        foreach(var std in toppers)
//        {
//            Console.WriteLine(std);
//        }
//    }
   
//}

