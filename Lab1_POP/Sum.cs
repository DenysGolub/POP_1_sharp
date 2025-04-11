using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_POP
{
    public class Sum
    {
        private Breaker _breaker;
        private int step;
        private int id;

        public Sum(Breaker breaker, int step, int id)
        {
            _breaker = breaker;
            this.step = step;
            this.id = id;
        }

        public void SequenceSum()
        {
            long sum = 0;
            int iter = 0;

            do
            {
                sum += step;
                iter++;
            }
            while (!_breaker.isStop(id));

            Console.WriteLine($"Thread №{id}; Sum: {sum}; Iterations: {iter}");
        }
    }

}
