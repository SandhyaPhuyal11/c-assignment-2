﻿using task3;

class Program
{
    static void Main(string[] args)
    {
        // Create object
        ParameterDemo demo = new ParameterDemo();

        // 1. Call Increase(ref number)
        int value = 20;
        demo.Increase(ref value);
        Console.WriteLine("Value after Increase: " + value);

        // 2. Call GetFullName(out fullname)
        string myFullName;
        demo.GetFullName(out myFullName);
        Console.WriteLine("Full Name: " + myFullName);

        // 3. Call SumAll(params...)
        int total = demo.SumAll(5, 10, 20, 15);
        Console.WriteLine("Sum of all numbers: " + total);
    }
}
