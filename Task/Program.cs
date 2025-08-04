using System;

class Task
{
    static void Main()
    {
        Console.Write("Enter First Number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());


        double sum = num1 + num2;
        double difference = num1 - num2;
        double multiple = num1 * num2;
        double divide = num1 / num2;

        Console.WriteLine("THE ARITHMATIC RESULTS ARE:-");
        Console.WriteLine("Addition : "+sum);
        Console.WriteLine("Substraction : "+difference);
        Console.WriteLine("Multiplication : "+multiple);
        Console.WriteLine("Division : " + divide);
    }
}