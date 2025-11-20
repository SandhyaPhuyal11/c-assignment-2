﻿using task5;

class Program
{
    static void Main(string[] args)
    {
        // ----------- PART 1: ENUM & DAY CHECK ------------
        Console.Write("Enter a day (Example: Sunday): ");
        string dayInput = Console.ReadLine().Trim().ToLower();

        DayType result;

        // Friday or Saturday → Weekend
        if (dayInput == "friday" || dayInput == "saturday")
            result = DayType.Weekend;
        else
            result = DayType.Weekday;

        Console.WriteLine($"It is: {result}");
        Console.WriteLine("-------------------------------------");

        // ----------- PART 2: RECORD, WITH, DECONSTRUCTION ------------

        // Create the first Book object
        Book book1 = new Book("C# Programming", "Sandhya Phuyal", 799.50);

        // Create second Book using WITH expression
        Book book2 = book1 with { title = "Advanced C#", price = 999.99 };

        // Print first book
        Console.WriteLine("First Book Object:");
        Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");

        Console.WriteLine("-------------------------------------");

        // Deconstruct second book
        var (title, author, price) = book2;

        Console.WriteLine("Deconstructed Second Book Object:");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}
