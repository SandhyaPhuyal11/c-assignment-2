using System;


internal class Program


{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2005, 6, 15); 
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = (int)(ageSpan.TotalDays / 365.25); 

        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
        Console.WriteLine($"Age: {ageInYears} years");

        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");
    }
}