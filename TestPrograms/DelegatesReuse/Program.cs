using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegatesReuse.Program;

namespace DelegatesReuse
{
    class DelegateProgram
    {
        public static void GetNumbers(int[] n,checkDel del)
        {
            foreach (int i in n)
            {
                if (del.Invoke(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Program
    {
        public delegate bool checkDel(int a); 
        static int[] data = { 1, 10, 32, 40, 50, 70, 80, 50, 20, 60 };
        static void Main(string[] args)
        {
            checkDel d = check;
            DelegateProgram.GetNumbers(data, d);
            Console.ReadLine();
        }


        public static bool check(int a)
        {
            return a > 50;
        }
    }
}
