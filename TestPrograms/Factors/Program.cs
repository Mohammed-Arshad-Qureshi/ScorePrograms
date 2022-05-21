using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to get Factors of that number :  ");
            int val = Convert.ToInt32(Console.ReadLine());
            Factors fac = new Factors();
            fac.check(val);
            Console.ReadLine();
        }
    }
}
