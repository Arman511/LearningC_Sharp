using System;
#nullable enable

public class Calc
{
    public static void Main(string[] args)
    {
        char @operator = 'a';
        int a = 0;
        int b = 0;

        string? input = "";

        do
        {
            Console.Write("Enter * to multiply, / to divide, + to add, % to get the modulo, or - to subtract: ");
            try
            {
                input = Console.ReadLine();
                @operator = input?[0] ?? ' ';
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input - press enter to continue");
                Console.ReadLine();
                continue;
            }

            if (!(@operator is '+' or '-' or '/' or '*' or '%'))
            {
                Console.WriteLine("Invalid input, not a valid operator - press enter to continue");
                Console.ReadLine();
            }
            else
            {
                break;
            }
        } while (true);

        do
        {
            Console.Write("Enter the first number: ");
            try
            {
                input = Console.ReadLine();
                a = int.Parse(input!);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input - press enter to continue");
                Console.ReadLine();
                continue;
            }
            break;
        } while (true);

        do
        {
            Console.Write("Enter the second number: ");
            try
            {
                input = Console.ReadLine();
                b = int.Parse(input!);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input - press enter to continue");
                Console.ReadLine();
                continue;
            }
            if (@operator=='/' && b == 0)
            {
                Console.WriteLine("Invalid input, you cannot divide by 0 - press enter to continue");
                Console.ReadLine();
                continue;
            }
            break;
        } while (true);

        int result = 0;
        switch (@operator)
        {
            case '*': result = a * b; break;
            case '/': result = a / b; break;
            case '-': result = a - b; break;
            case '+': result = a + b; break;
            case '%': result = a % b; break;
        }

        Console.WriteLine("{0} {1} {2} = {3}", a, @operator, b, result);
    }
}
