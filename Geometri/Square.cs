namespace Geometri
{
    public class Square
    {
        private int length;
        public int Length
        {
            get => length;
            set => length = value;
        }

        private int height;
        public int Height
        {
            get => height;
            set => height = value;
        }

        public Square() { }

        public Square(int length, int height)
        {
            this.length = length;
            this.height = height;
        }

        public Square(int size)
        {
            length = size;
            height = size;
        }

        public int Perimeter() => length + height;
        public int Area() => length * height;
    }
}