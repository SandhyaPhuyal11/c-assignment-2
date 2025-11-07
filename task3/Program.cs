using System;

internal class Program
{
    static void Main(string[] args)
    {
        byte myByte = 10;
        short myShort = 2000;
        int myInt = 100000;
        long myLong = 9876543210;
        float myFloat = 5.6f;
        double myDouble = 9.99;
        decimal myDecimal = 123.456m;
        char myChar = 'A';
        bool myBool = true;

        int number = 42;
        string numberAsString = number.ToString(); 

        string value = "3.14";
        double convertedDouble = Convert.ToDouble(value); 

        Console.WriteLine($"byte value: {myByte}");
        Console.WriteLine($"short value: {myShort}");
        Console.WriteLine($"int value: {myInt}");
        Console.WriteLine($"long value: {myLong}");
        Console.WriteLine($"float value: {myFloat}");
        Console.WriteLine($"double value: {myDouble}");
        Console.WriteLine($"decimal value: {myDecimal}");
        Console.WriteLine($"char value: {myChar}");
        Console.WriteLine($"bool value: {myBool}");

        Console.WriteLine($"Converted int to string: {numberAsString}");
        Console.WriteLine($"Converted string '3.14' to double: {convertedDouble}");
    }
}