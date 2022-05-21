using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class StringPalindrome
    {
        public void ToCheck(string value)
        {
            string GivenString = value;
            string reverse =string.Empty;
            for (int i = value.Length-1; i >= 0; i--)
            {
                reverse = reverse + value[i].ToString();
            }

            if (GivenString.Equals(reverse))
                Console.WriteLine(" ---  Entered string is PALINDROME ---");
            else
                Console.WriteLine(" --- Entered String is Not a PALINDROME ---");
        }

    }
}
