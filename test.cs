using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Enter first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /):");
        string op = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        double num2 = double.Parse(Console.ReadLine());

        double result = op switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException(),
            _ => throw new InvalidOperationException("Invalid operator")
        };

        Console.WriteLine($"Result: {result}");
    }
}