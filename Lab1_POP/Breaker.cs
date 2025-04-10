using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_POP
{
    public class Breaker
    {
        private ThreadInfo[] threads;

        public Breaker(int numThreads)
        {
            threads = new ThreadInfo[numThreads];
            Random rnd = new Random();
            for (int i = 0; i < numThreads; i++)
            {
                int t = rnd.Next(2000, 5000);
                threads[i] = new ThreadInfo(i, t);
            }
        }

        private void MinusValueFromArray(int value)
        {
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Time -= value;
            }
        }

        public void Run()
        {
            Array.Sort(threads, (x, y) => x.Time.CompareTo(y.Time));

            for (int i = 0; i < threads.Length; i++)
            {
                int currentTime = threads[i].Time;
                Thread.Sleep(currentTime);
                threads[threads[i].Id].CanStop = true;
                MinusValueFromArray(currentTime);
            }
        }
        public bool isStop(int id)
        {
            return threads[id].CanStop;

        }
    }

}
