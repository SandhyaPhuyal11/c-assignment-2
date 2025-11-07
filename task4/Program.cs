using System;

class Program
{
    static void Main(string[] args)
    {
        int[] favoriteNumbers = { 7, 21, 3, 14, 9 };

        Array.Sort(favoriteNumbers);
        Array.Reverse(favoriteNumbers);

        Console.WriteLine("Numbers in descending order:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        int position = Array.IndexOf(favoriteNumbers, 14);
        if (position != -1)
        {
            Console.WriteLine($"The number 14 is at position {position} in the array.");
        }
        else
        {
            Console.WriteLine("The number 14 is not in the array.");
        }
    }
}