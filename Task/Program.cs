

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
using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            // Loop from 2 to number-1
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine($"{number} is a Prime number.");
        else
            Console.WriteLine($"{number} is NOT a Prime number.");

        Console.ReadKey(); // Pause the console window
    }
}
