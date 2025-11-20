﻿using task2;

class Program
{
    static void Main(string[] args)
    {
        // Create object of Calculator class
        Calculator calc = new Calculator();

        // Call PrintWelcome
        calc.PrintWelcome();

        // Call Add method
        int sum = calc.Add(15, 20);

        // Call Multiply method (optional parameter used)
        int product1 = calc.Multiply(8);      // num2 = default 1
        int product2 = calc.Multiply(8, 4);   // num2 = 3

        // Print results
        Console.WriteLine("Addition Result: " + sum);
        Console.WriteLine("Multiplication Result (default): " + product1);
        Console.WriteLine("Multiplication Result (8 * 4): " + product2);
    }
}
