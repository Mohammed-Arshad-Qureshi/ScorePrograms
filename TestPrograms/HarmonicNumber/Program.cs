using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            HarmonicNumber hn = new HarmonicNumber();
            Console.WriteLine("Enter the range for Harmonic number to print :  ");
            int val = Convert.ToInt32(Console.ReadLine());
            hn.Harmonic(val);
            Console.ReadLine();
        }
    }
}
