using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        public class Solution
        {

            public static int Divide(int dividend, int divisor)
            {

                if (divisor == 0)
                {
                    throw new DivideByZeroException();
                }

                long result = (long)dividend / (long)divisor;

                if (result < int.MinValue || result > int.MaxValue)
                {
                    return (int)Math.Pow(2, 31) - 1;
                }

                return (int)result;

            
            }
        }
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
