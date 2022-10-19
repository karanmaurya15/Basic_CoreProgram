using System.Diagnostics.CodeAnalysis;

namespace Basic_CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Dividend");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            long Cal = Math.DivRem(Dividend, Divisor, out long result);

            Console.WriteLine("Quotient is : " + Cal);
            Console.WriteLine("Remainder is: " + result);
        }   
    }
}