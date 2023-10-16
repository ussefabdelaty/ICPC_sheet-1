namespace Simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string GetNumbers = Console.ReadLine();

            string[] GetNum = GetNumbers.Split();

           if (GetNum.Length ==2 && long.TryParse(GetNum[0] , out long x ) 
                && long.TryParse(GetNum[1],out long y))
            {
                Console.WriteLine($"{x} + {y} = {x+y}");
                Console.WriteLine($"{x} * {y} = {x*y}");
                Console.WriteLine($"{x} - {y} = {x-y}");
            }
           else
            {
                Console.WriteLine("unvalid inputs ,try again!");
            }





        }
    }
}