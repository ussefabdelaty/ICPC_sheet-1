namespace H_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string numbers = Console.ReadLine();

            string[] arrNumbers = numbers.Split(' ');
            
            if(arrNumbers.Length == 2 &&
                double.TryParse(arrNumbers[0], out double A) &&
                double.TryParse(arrNumbers[1], out double B)&& B !=0)
            {
                double cal = A / B;
                Console.WriteLine($"floor {A} / {B} = {Math.Floor(cal)}");
                Console.WriteLine($"ceil {A} / {B} = {Math.Ceiling(cal)}");
                Console.WriteLine($"round {A} / {B} = {Math.Round(cal, MidpointRounding.AwayFromZero)}");
            }
            else { Console.WriteLine("enter valid numbers"); }

            Console.ReadKey();  

            
        }
    }
}


