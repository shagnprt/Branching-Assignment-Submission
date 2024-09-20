using System;

class Program
{
    static void Main()
    {
        // Display the welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the weight of the package
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine()); // Read and convert user input to a double

        // Check if the package weight exceeds the limit of 50
        if (weight > 50)
        {
            // If weight exceeds 50, display an error message and end the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program
        }

        // Prompt the user to enter the width of the package
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine()); // Read and convert user input to a double

        // Prompt the user to enter the height of the package
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine()); // Read and convert user input to a double

        // Prompt the user to enter the length of the package
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine()); // Read and convert user input to a double

        // Calculate the total sum of the package dimensions (width + height + length)
        double totalDimensions = width + height + length;

        // Check if the total dimensions exceed the limit of 50
        if (totalDimensions > 50)
        {
            // If total dimensions exceed 50, display an error message and end the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the shipping quote:
        // Multiply width, height, and length together, then multiply by the weight, and divide by 100
        double quote = (width * height * length * weight) / 100;

        // Display the shipping quote formatted as a dollar amount with two decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user
        Console.WriteLine("Thank you!");
    }
}

