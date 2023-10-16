/*namespace erea_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi= 3.141592653d;
            double.TryParse(Console.ReadLine(), out double R);

            if (R >= 1 && R <= 100)
            {
                double area = pi * R * R;
                area = Math.Round(area,9);
                Console.WriteLine($"area = {area}");
            }
            else
            {
                   Console.WriteLine("enter valid number"); 
            }
            Console.ReadKey();
        }
    }
}*/

using System;

class Program
{
    static void Main()
    {
        const double pi = 3.141592653;
        double R;

        // Read the radius from the user
        Console.Write("Enter the radius (1 ≤ R ≤ 100): ");
        if (double.TryParse(Console.ReadLine(), out R) && R >= 1 && R <= 100)
        {
            // Calculate the area of the circle
            double area = pi * R * R;

            // Print the area with 9 digits after the decimal point
            Console.WriteLine("Area = " + area.ToString("F9"));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid radius within the specified range.");
        }
    }
}



