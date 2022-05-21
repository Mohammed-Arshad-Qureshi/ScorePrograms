using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber
{
    class HarmonicNumber
    {
        public void Harmonic(int value)
        {
            double d = 0;
            for (int i = 1; i <= value; i++)
            {
                d = d + 1d / i;

            }
            Console.WriteLine(d);
        }
    }
}
