using System.Diagnostics.CodeAnalysis;

namespace Basic_CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Second number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            int d = b;
            
            Console.WriteLine("After Swapping the value of first number is: " + d);
            Console.WriteLine("After Swapping the value of Second number is: " + c);
        }
    }   
    
}   