namespace Basic_DT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Only one line containing the following space-separated values: int, long long, char, float and double respectively.");
          string Integers =   Console.ReadLine();
            string[] arrnumbers = Integers.Split();

            if (arrnumbers.Length == 5 &&
                int.TryParse(arrnumbers[0], out int x ) &&
                long.TryParse(arrnumbers[1],    out long y ) && 
                char.TryParse(arrnumbers[2],    out char c ) &&
                float.TryParse(arrnumbers[3],   out float f ) &&
                double.TryParse(arrnumbers[4],  out double d ) 
                )
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(c);
                Console.WriteLine(f);
               // Console.WriteLine(d);
                string formattedNumber = d.ToString("0.0");
                Console.WriteLine(formattedNumber); ;
            }
            else
            {
                Console.WriteLine("enter valid inputs!");
            }
        }
    }
}