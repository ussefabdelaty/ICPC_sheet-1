/*namespace N_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char.TryParse(Console.ReadLine(), out char x); 
            
            if (char.IsUpper(x))
            {
               
                Console.WriteLine(char.ToLower(x));
            }
            else if (char.IsLower(x))
            {
                Console.WriteLine(char.ToUpper(x)); 
            }
            else
            {
                Console.WriteLine("enter a valid input"); 
            }

            Console.ReadKey();
        }
    }
}*/

//the best soltuion for runtime 
using System;

class Program
{
    static void Main()
    {
        char x;
        if (char.TryParse(Console.ReadLine(), out x))
        {
            if (char.IsLetter(x))
            {
                // Toggle the case
                char convertedCharacter = char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x);
                Console.WriteLine(convertedCharacter);
            }
            else
            {
                Console.WriteLine("Enter a valid input.");
            }
        }
        else
        {
            Console.WriteLine("Enter a valid input.");
        }

        Console.ReadKey();
    }
}
