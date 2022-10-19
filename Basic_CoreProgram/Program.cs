using System.Diagnostics.CodeAnalysis;

namespace Basic_CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to calculate Prime Factors:");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= Number / 2; i++)
            {
                while (Number % i == 0)
                {
                    Console.WriteLine(i);
                    Number = Number / i;
                }
            }
            if (Number > 2)
            {
                Console.WriteLine(Number);
            }
        }   
    }
}