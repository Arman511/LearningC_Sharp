using System.Diagnostics;

namespace LearningC_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello word");

            Human jeff = new Human("jeff", "Bell", 40);
            jeff.IntroduceMyself();

            Human jermey = new Human("Jeremey", "Geoff", "Bell", 30);
            jermey.IntroduceMyself();


            MyRectangle rec1 = new MyRectangle();
            rec1.Width = 30;
            rec1.Height = 30;
            Human denis = new Human("Dennis", "Bell", 30);
            denis.IntroduceMyself();
        }

        
    }
}