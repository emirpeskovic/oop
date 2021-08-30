using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Square square1 = new Square();
            square1.Length = 24;
            square1.Height = 38;

            Console.WriteLine($"Square1 | Length: {square1.Length} | Height: {square1.Height} | Area: {square1.Area()} | Perimeter: {square1.Perimeter()}");

            square1.Length = random.Next(1, 40);
            square1.Height = random.Next(1, 40);

            Console.WriteLine($"Square1 | Length: {square1.Length} | Height: {square1.Height} | Area: {square1.Area()} | Perimeter: {square1.Perimeter()}");

            Square square2 = new Square(25);
            Console.WriteLine($"Square2 | Length: {square2.Length} | Height: {square2.Height} | Area: {square2.Area()} | Perimeter: {square2.Perimeter()}");
        }
    }
}
