Djenan
college: Academy of learning
companey: west gate puplic school
contact: 226-890-765 
  INF: weight validation 50kg<
    cost calculation <width*height*length*weight> divided 100

    ``csharp
using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if weight is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End program
        }

        // Prompt user for package dimensions
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if total dimensions exceed limit
        double dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
