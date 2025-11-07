using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };

        fruits.Add("Orange");
        fruits.Remove("Mango");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

        fruitDictionary.Add(4, "Orange");

        Console.WriteLine("\nFruits in the dictionary:");
        foreach (KeyValuePair<int, string> entry in fruitDictionary)
        {
            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
        }
    }
}