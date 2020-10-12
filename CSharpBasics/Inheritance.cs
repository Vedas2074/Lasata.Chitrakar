using System;
public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public void PrintDetails()
    {
        Console.WriteLine("Print details for shape...");
    }
}
public class Rectangle : Shape
{
    
    public Rectangle(double l,double b)
    {
        this.Length = l;
        this.Breadth = b;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double GetArea() => Length * Breadth;
    public override double GetPerimeter() => 2 * (Length + Breadth);

    public new void PrintDetails()
    {
        Console.WriteLine("Print details for shape...");
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        Console.WriteLine($"Area: {this.GetArea()}, Perimeter: {this.GetPerimeter()}");
    }
}
public class Square : Rectangle
{
    public Square(double s) : base(s, s)
    {
        //base.GetArea();
    }
    //public double Side { get; set; }
    //public override double GetArea() => Side * Side;
    //public override double GetPerimeter() => 4 * Side;
}
public class Circle : Shape
{
    public Circle(double r)
    {
        Radius = r;
    }

    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}



// multiple inheritance not allowed but can be used with interface