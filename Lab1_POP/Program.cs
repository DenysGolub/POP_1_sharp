using System;
using System.Threading;
namespace Lab1_POP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int threadsNumber = 100;

            Random rnd = new Random();
            Breaker breaker = new Breaker(threadsNumber);

            for (int i = 0; i < threadsNumber; i++)
            {
                int step = rnd.Next(1, 10);
                Sum s = new Sum(breaker, step, i);
                new Thread(s.SequenceSum).Start();
            }

            new Thread(breaker.Run).Start();
            Console.ReadLine(); 
        }
    }
}
