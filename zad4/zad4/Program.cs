using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int min = int.MaxValue;
            int result = 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    int diff = Math.Abs(sum - target);
                    if (diff == 0) return sum;

                    if (diff < min)
                    {
                        min = diff;
                        result = sum;
                    }
                    if (sum <= target)
                        j++;
                    else
                        k--;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
