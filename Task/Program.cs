

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

using System;

class Animal
{
   public string Name;
    public int Age;

    public void speak()
    {
        Console.WriteLine($"iam {Name} and iam {Age} years old. ");
    }
   public class Dog : Animal
    {
        public string breed;
    }
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meoww!!");
        }
    }
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Name = "Buddy";
            dog.Age = 10;
            dog.breed = "Golden Retriever";
            dog.speak();

            Cat cat= new Cat();
            cat.Name = "charlie";
            cat.Age = 2;
            cat.Meow();
            cat.speak();
        }
    }
}

