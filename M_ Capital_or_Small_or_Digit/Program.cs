/*namespace M__Capital_or_Small_or_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            char.TryParse(x, out char X);

            if (char.IsDigit(X))
            {
                Console.WriteLine("IS DIGIT");
            }
            else if(char.IsLetter(X))
            {
                if (char.IsUpper(X))
                {
                    Console.WriteLine("ALPHA");
                    Console.WriteLine("IS CAPITAL");
                }
                else
                {
                    Console.WriteLine("ALPHA");
                    Console.WriteLine("IS SMALL");
                }
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

        string x = Console.ReadLine();

        char.TryParse(x, out char X);

        if (X >= '0' && X <= '9')
        {
            Console.WriteLine("IS DIGIT");
        }
        else if (X >= 'A' && X <= 'Z')
        {
            Console.WriteLine("ALPHA");
            Console.WriteLine("IS CAPITAL");
        }
        else if (X >= 'a' && X <= 'z')
        {
            Console.WriteLine("ALPHA");
            Console.WriteLine("IS SMALL");
        }
    }
}
