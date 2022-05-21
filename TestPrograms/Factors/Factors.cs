using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    class Factors
    {
        public void check(int n)
        {
            Console.Write("The factors of given numbes are :  ");
            for (int i = 1; i <= n; i++)  
                        
            {
                if(n%i == 0)
                {
                    Console.Write(i + " ");

                }
            }
        }
    }
}
