namespace I_welcome_for_you
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            string [] arr_inputs = inputs.Split(' ');
            if(arr_inputs.Length == 2 &&
                int.TryParse(arr_inputs[0], out int A)&&
                int.TryParse(arr_inputs[1], out int B) 
                )
            { 
                if (A >= B)
                {
                    Console.WriteLine("Yes");
                }
                else { Console.WriteLine("No"); }
            }
            else
            {
                Console.WriteLine("enter valid inputs");
            }

        }
    }
}