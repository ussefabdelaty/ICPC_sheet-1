namespace J_multiplies
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string inputs = Console.ReadLine();

            string[] arr_inputs = inputs.Split(' ');

            if (arr_inputs.Length == 2 &&
                int.TryParse(arr_inputs[0],out int A)&&
                int.TryParse(arr_inputs[1], out int B)
                ) 
            {
                if (A % B == 0 || B % A == 0)
                {
                    Console.WriteLine("Multiples");
                }
                else
                {
                    Console.WriteLine("No Multiples");
                }

            }
            else
            {
                Console.WriteLine("input valid numbers!");
            }
            Console.ReadKey();
        }
    }
}