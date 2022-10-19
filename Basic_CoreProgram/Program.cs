namespace Basic_CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter power of 2");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0 && N < 31)
            {
                for (int i = 1; i <= N; i++)
                {
                    double value = Math.Pow(2, i);
                    Console.WriteLine(value);
                }
            }
            else
                Console.WriteLine("Invalid Number");
        }   
    }
}