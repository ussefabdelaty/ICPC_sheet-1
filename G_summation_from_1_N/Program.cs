namespace G_summation_from_1_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number (N) between '1 to 10^9' ");

            if (long.TryParse(Console.ReadLine(), out long N) && N >=1 && N<=1000000000)
            {
                //best sloution 
                long summetion = (N * (N + 1)) / 2;

                //int summetion = 0;
                //for (int i = 1; i <= N; i++)
                //{
                //    summetion += i;
                //}

                Console.WriteLine(summetion);
            }
            else
            {
                Console.WriteLine("enter a valid number");
            }
            Console.ReadKey();




      
        }
    }
}