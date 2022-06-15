using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        public class HappyNumber
        {
                
            public bool IsHappy(int n)
            {
                int sum = 0;

                while (n > 0)
                {
                    var lastNumber = n % 10;
                    sum = sum + lastNumber * lastNumber;
                    n = (n - lastNumber) / 10;

                    if ((sum == 1 || sum == 100 || sum == 4) && n == 0)
                    {
                        break;
                    }

                    if (n == 0)
                    {
                        n = sum;
                        sum = 0;
                    }
                }

                return sum == 1 || sum == 100 ? true : false;
            }
        }
        static void Main(string[] args)
            {
                
            }
    }
}