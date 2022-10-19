namespace Basic_CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an year to check");
            double year = Convert.ToDouble(Console.ReadLine());
            if (year > 999)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("It is a Leap Year");
                }
                else
                    Console.WriteLine("Not a Leap Year");
            }
            else
                Console.WriteLine("Invalid Entry");
        }   
    }
}