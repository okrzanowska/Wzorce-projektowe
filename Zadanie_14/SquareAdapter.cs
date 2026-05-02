using System;

public class Square
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double GetSide()
    {
        return side;
    }
}

public interface IShape
{
    double GetArea();
}

public class SquareAdapter : IShape
{
    private Square square;

    public SquareAdapter(Square square)
    {
        this.square = square;
    }

    public double GetArea()
    {
        double side = square.GetSide();
        return side * side;
    }
}

// Kod testowy
public class Program
{
    public static void Main(string[] args)
    {
        Square square = new Square(5);
        IShape shape = new SquareAdapter(square);

        Console.WriteLine($"Pole kwadratu: {shape.GetArea()}");
    }
}