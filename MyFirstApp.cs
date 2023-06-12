using System;
public class MyFirstApp
{
    public static int Main(string[] args)
    {
        int a;
        int b;
        Console.Write("What is number 1: ");
        int.TryParse(Console.ReadLine(), out a);
        Console.Write("What is number 2: ");
        int.TryParse(Console.ReadLine(), out b);
        int c = a + b;
        Console.WriteLine("The sum of the answer is: " + c);
        Console.Write("Enter name: ");
        string? name = Console.ReadLine();
        Console.WriteLine(name);
        return 0;

    }
}