namespace Basic_CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coin Flip Count");
            double Toss = Convert.ToDouble(Console.ReadLine());
            int Hcount = 0;
            int Tcount = 0;
            for (int i = 0; i < Toss; i++)
            {
                Random random = new Random();
                int coin = random.Next(0, 2);
                if (coin < .5)
                {
                    Hcount += 1;
                }
                else
                    Tcount += 1;
            }
            Console.WriteLine("Head count: " + Hcount);
            Console.WriteLine("Tail count: " + Tcount);
            double Hpercent = ((double)Hcount / Toss) * 100;
            Console.WriteLine("Head percentage is: " + Hpercent);
            double Tpercent = (((double)Tcount / Toss)) * 100;
            Console.WriteLine("Tail percentage is: " + Tpercent);
        }   
    }
}