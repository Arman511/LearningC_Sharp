using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] grades;
        grades = new int[5];
        Random rand = new Random();
        for (int i = 0; i < grades.Length; i++)
        {
            grades[i] = rand.Next(1000);
        }

        foreach (int i in grades)
        {
            Console.WriteLine(i);
        }
    }
}
