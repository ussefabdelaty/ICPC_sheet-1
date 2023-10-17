namespace F_Digit_Summition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine(); 
            string[] InputsNumbers = inputs.Split(' ');

            if (InputsNumbers.Length == 2 &&
                ulong.TryParse(InputsNumbers[0], out ulong N)&&
                ulong.TryParse(InputsNumbers[1], out ulong M)) 
            {
                int lastDigitN = (int)(N % 10);
                int lastDigitM = (int)(M % 10);

                int sumLastDigit = lastDigitN + lastDigitM;
                Console.WriteLine(sumLastDigit);
            }
            else
            {
                Console.WriteLine("input valid numbers!!");
            }

            Console.ReadKey();  
           
        }
    }
}