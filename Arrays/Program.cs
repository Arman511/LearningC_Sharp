using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] grades;
        grades = new int[5];
        Random rand = new Random();
        RandArrayAndDisplay(grades, rand);

        Console.WriteLine();
        InlineArrayInt();
        Console.WriteLine();
        grades = InlineArrayReturning();
        Console.WriteLine();
        InlineArrayString();

    }

    private static void RandArrayAndDisplay(int[] grades, Random rand)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            grades[i] = rand.Next(1000);
        }

        foreach (int i in grades)
        {
            Console.WriteLine(i);
        }
    }

    private static void InlineArrayInt()
    {
        int[] neoGrades = { 123, 123, 123, 234, 645 };
        foreach (int i in neoGrades)
        {
            Console.WriteLine(i);
        }
    }

    private static int[] InlineArrayReturning()
    {
        int[] grades = new int[] { 123, 123, 123, 234, 645 };
        foreach (int i in grades)
        {
            Console.WriteLine(i);
        }

        return grades;
    }

    private static void InlineArrayString()
    {
        String[] friends = { "Jeff", "Jermey", "James", "Jamil", "Jessica" };

        foreach (string i in friends)
        {
            Console.WriteLine(i);
        }
    }
}
