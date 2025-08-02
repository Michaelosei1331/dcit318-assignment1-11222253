using System;

public class TriangleIdentifier
{
    public void Run()
    {
        Console.Write("Enter the length of side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("This is an Equilateral triangle.");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("This is an Isosceles triangle.");
        else
            Console.WriteLine("This is a Scalene triangle.");
    }
}
