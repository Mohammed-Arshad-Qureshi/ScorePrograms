using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Fibonacci
    {
        public void FibonacciSeries(int fib)
        {
            int n1 = -1, n2 = 1, n3 = 0;
            for (int i = 0; i < fib; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
