using System;

//LSP

class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square
{
    public int SideLength { get; set; }
    public int GetArea()
    {
        return SideLength * SideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 5;
        rectangle.Height = 10;
        Console.WriteLine(rectangle.GetArea());

        Square square = new Square();
        square.SideLength = 5;

        Console.WriteLine(square.GetArea());
        Console.ReadKey();
    }
}
