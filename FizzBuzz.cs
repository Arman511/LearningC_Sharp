using System;

public class FizzBuzz
{
    public static int Main(string[] args)
    {
        string ans = "";
        for (byte i = 1; i <= 100; i++)
        {
            ans = "";
            if (i % 3 == 0) { ans += "Fizz"; }
            if (i % 5 == 0) { ans += "Buzz"; }
            if (ans == "")
            {
                Console.WriteLine(i);
            }
            else { Console.WriteLine(ans); }
        }
        return 0;
    }


}