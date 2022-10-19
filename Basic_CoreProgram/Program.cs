using System.Diagnostics.CodeAnalysis;

namespace Basic_CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number c");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("a is largest");
            }
            else if (c > b && c > a)
            {
                Console.WriteLine("c is largest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is Largest");
            }
            else
                Console.WriteLine("Numbers are Equal");
        }
    }   
    
}   