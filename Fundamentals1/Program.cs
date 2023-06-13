using System.Collections;

class Program
{
    static int[,] matrix =
    {
        {1,2,3 },
        {4,5,6},
        {6 ,7,8}
    };
    static void Main(string[] args)
    {
        //Array();

        //JaggedArrays();

        ArrayList myArrayList = new ArrayList();
        ArrayList myArrayList2 = new ArrayList(100);

        myArrayList.Add(1);
        SeeArray(myArrayList);
        myArrayList.Add("Hello");
        SeeArray(myArrayList);

        myArrayList.Add("World");
        SeeArray(myArrayList);

        myArrayList.Add("Japan");
        SeeArray(myArrayList);


        myArrayList.Remove(1);
        SeeArray(myArrayList);

        myArrayList.RemoveAt(0);
        SeeArray(myArrayList);
        myArrayList.Add(4);
        myArrayList.Add(5);
        myArrayList.Add(46);
        myArrayList.Add(7);
        myArrayList.Add(8);
        myArrayList.Add(2);
        myArrayList.Add(6);
        int sum = 0;
        foreach (object i in myArrayList)
        {
            if(i is int)
            {
                sum += Convert.ToInt32(i);
            }
        }
        Console.WriteLine("Sum of ArrayList: "+sum);
    }

    private static void SeeArray(ArrayList array)
    {
        foreach (object item in array) 
        {
            Console.Write(item.ToString()+" ");
        }
        Console.WriteLine();
    }

    private static void JaggedArrays()
    {
        Console.WriteLine();

        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[3] { 2, 4, 7 };
        jaggedArray[1] = new int[5] { 2, 4, 5, 6, 7 };
        jaggedArray[2] = new int[2] { 6, 7 };

        int[][] jaggedArray2 = new int[][]{
            new int[2] {1,2},
            new int[3] {3,4,5},
            new int[4] {6,7,8,9},

        };

        foreach (var item in jaggedArray2)
        {
            foreach (var x in item)
            {
                Console.Write(x + " ");
            }
        }
    }

    private static void Array()
    {
        foreach (int x in matrix)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                matrix[x, y] = matrix[x, y] * 2;
                Console.Write(matrix[x, y] + " ");
            }
        }
        Console.WriteLine();
        foreach (var item in matrix)
        {
            Console.Write(item + " ");
        }
    }
}
