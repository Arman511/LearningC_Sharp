namespace LearningC_
{
    internal class MyRectangle
    {
        int height;
        int width;
        int area;

        public int Area
        {
            get
            {
                return this.height*this.width;
            }
        }

        public int Height { get; set; }
        public int Width
        {
            get
            {
                return this.width;
            }
            set 
            {
                this.width = value < 0 ? -value : value;
            }
        }

        public MyRectangle()
        {
        }
    }
}