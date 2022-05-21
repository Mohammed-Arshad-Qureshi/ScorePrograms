using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fb = new Fibonacci();
            Console.Write("Enter the range for Fibonacci series:  ");
            int range = Convert.ToInt32(Console.ReadLine());
            fb.FibonacciSeries(range);
            Console.ReadLine();
        }
    }
}
