using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- DCIT 318 Assignment ---");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new GradeCalculator().Run();
                    break;
                case "2":
                    new TicketPriceCalculator().Run();
                    break;
                case "3":
                    new TriangleIdentifier().Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting... Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
