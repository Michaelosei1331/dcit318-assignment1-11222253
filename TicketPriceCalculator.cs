using System;

public class TicketPriceCalculator
{
    public void Run()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 12 || age >= 65)
            Console.WriteLine("Your ticket price is: GHC7");
        else
            Console.WriteLine("Your ticket price is: GHC10");
    }
}
