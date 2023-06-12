public class Program
{
    public static void Main(string[] args)
    {
        int[,,] matrix = {
            {
                {1,2,3},
                {1,2,3},
                {1,2,3}
            },
            {
                {4,5,6},
                {4,5,6},
                {4,5,6}
            },
            {
                {7,8,9},
                {7,8,9},
                {7,8,9}
            },
        };

        Console.WriteLine("Last Value is {0}", matrix[2, 2, 2]);

        int[,] twoD = new int[,] {
            {1,2,3},
            {4,5,6},
            {8,9,0}
        };
        Console.WriteLine("Central Value is {0}", twoD[1, 1]);


        string[,] stringArray = new String[5, 2]{
            {"1", "2"}, {"3","4"},{"5","6"},{"7","8"},{"9","0"}
        };

        int dimension = stringArray.Rank;
        
        Tuple();



    }

    private static void Tuple()
    {
        var stuff = ("hello", 123, true);
        Console.WriteLine(stuff.Item1);
    }
}