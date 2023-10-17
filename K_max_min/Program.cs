namespace K_max_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // best practice solution with perfect runtime 
            Console.WriteLine("Enter three numbers A, B, and C (-105 ≤ A, B, C ≤ 105):");
            string input = Console.ReadLine();

            string[] inputNumbers = input.Split(' ');

            if (inputNumbers.Length == 3 &&
                int.TryParse(inputNumbers[0], out int A) &&
                int.TryParse(inputNumbers[1], out int B) && 
                int.TryParse(inputNumbers[2], out int C))
            {
                int min = Math.Min(Math.Min(A, B), C);
                int max = Math.Max(Math.Max(A, B), C);

                Console.WriteLine($"{min} {max}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            /*  string inputs = Console.ReadLine();

              string[] arr_inputs = inputs.Split(' ');

              if (arr_inputs.Length == 3 &&
                  int.TryParse(arr_inputs[0], out int A) &&
                  int.TryParse(arr_inputs[1], out int B)&&
                   int.TryParse(arr_inputs[2], out int C)
                  )
              {
                  if (A>B && A>C && B<C)
                  {
                      Console.WriteLine($"{B} {A}");
                  }
                  else if (A >= B && A >= C &&  C <= B)
                  {
                      Console.WriteLine($"{C} {A}");
                  }
                  else if (A <= B && B >= C && A <= C)
                  {
                      Console.WriteLine($"{A} {B}");
                  }
                  else if (A <= B && B>= C && C <= A)
                  {
                      Console.WriteLine($"{C} {B}");
                  }
                  else if (C >= B && A <= C && B >= A)
                  {
                      Console.WriteLine($"{A} {C}");
                  }
                  else if (C >= B && A <= C && B <= A )
                  {
                      Console.WriteLine($"{B} {C}");
                  }
              }
              else { Console.WriteLine("enter valid numbers!"); }

                  Console.ReadKey();
              */
        }
    }
}