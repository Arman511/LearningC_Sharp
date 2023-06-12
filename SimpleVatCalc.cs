using System;
public class SimpleVatCalc
{
    public static int Main(string[] args)

    {
        Console.WriteLine("Vat Calc");
        float totalIncome = 0f;
        float temp = 0f;
        int count = 0;
        while (true) {
            Console.Write("Enter income from source " + ++count +" or enter 'q' to finish: ");
            var input = Console.ReadLine();
            bool wasNum= float.TryParse(input, out temp);
            if (wasNum) { totalIncome += temp; continue; }
            if (input == "q")
            {
                break;
            }
            Console.Write("Invalid Input - Press enter to continue");
        }
        float totalTax = 0.2f * totalIncome;
        Console.WriteLine("Of the total income of £" + Math.Round((decimal)totalIncome, 2) + " you pay £" + Math.Round((decimal)totalTax, 2) + " in tax");
        
        return 0; }
}