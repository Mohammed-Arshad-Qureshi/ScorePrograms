using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            //For String PALINDROME
            StringPalindrome sp = new StringPalindrome();
            Console.Write("Enter String to check if it palindrom or not:  ");
            string st = Console.ReadLine();
            sp.ToCheck(st);
            Console.ReadKey();
        }
    }
}
