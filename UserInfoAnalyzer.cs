using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        int age = 0;

        try
        {
            age = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input. Age set to 0 by default.");
        }

        Console.WriteLine($"Hello, {name}! You are {age} years old.");
        Console.WriteLine("Your name in uppercase: " + name.ToUpper());
        Console.WriteLine("Name contains letter 'i'? " + name.Contains("i"));

        int[] favoriteNumbers = { 3, 7, 21 };
        Console.WriteLine("Your favorite numbers:");
        foreach (int n in favoriteNumbers)
        {
            Console.WriteLine(n);
        }

        List<string> skills = new List<string>() { "C#", "Git", "VS" };
        skills.Add("OOP");
        skills.Remove("Git");

        Console.WriteLine("Your skills:");
        foreach (string skill in skills)
        {
            Console.WriteLine(skill);
        }

        Console.WriteLine("Enter two numbers to multiply:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Result: " + Multiply(a, b));
        Console.WriteLine("Done");
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }
}
