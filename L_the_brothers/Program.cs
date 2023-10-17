namespace L_the_brothers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  string FirstPerson = Console.ReadLine();
            string[] Fperson = FirstPerson.Split(' ');

            string SecondPerson  = Console.ReadLine(); 
            string[] Sperson = SecondPerson.Split(' ');


            if (Fperson.Length == SecondPerson.Length | Fperson[1] == Sperson[1])
            {
                Console.WriteLine("ARE Brothers");
            }
            else
            {
                Console.WriteLine("NOT");
            }*/

            //another solution 

            Console.WriteLine("Enter the first person's first and second name:");
            string[] person1Names = Console.ReadLine().Split(' ');

            Console.WriteLine("Enter the second person's first and second name:");
            string[] person2Names = Console.ReadLine().Split(' ');

            string secondName1 = person1Names.Length > 1 ? person1Names[1] : "";
            string secondName2 = person2Names.Length > 1 ? person2Names[1] : "";

            if (secondName1 == secondName2)
            {
                Console.WriteLine("ARE Brothers");
            }
            else
            {
                Console.WriteLine("NOT");
            }
            Console.ReadKey();
        }
    }
}