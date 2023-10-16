namespace Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();

            string[] inputs_numbers = inputs.Split(' ');


            if (inputs_numbers.Length == 4 &&
                long.TryParse(inputs_numbers[0], out long A)&&
                long.TryParse(inputs_numbers[1], out long B)&&
                long.TryParse(inputs_numbers[2], out long C)&&
                long.TryParse(inputs_numbers[3], out long D))
            {
                if (A >= -100000 && A <= 100000 &&
                    B >= -100000 && B <= 100000 &&
                    C >= -100000 && C <= 100000 &&
                    D >= -100000 && D <= 100000)
                {
                    long X = (A * B) - (C * D);
                    Console.WriteLine($"Difference = {X}");
                }
                else
                {
                    Console.WriteLine("Invalid Inputs");
                }
            }
            else
            {
                Console.WriteLine("Invalid Inputs");
            }
            Console.ReadKey();

        }
    }
}
