using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11
{
    public class Program
    {
        static public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int k = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                nums[k++] = nums[j];

                while (j < nums.Length - 1 && nums[j] == nums[j + 1])
                    j++;
            }

            return k;
        }
    static void Main(string[] args)
            {
                int[] nums = new int[] { 1, 1, 2, 2, 3, 4, 4 };
                int newLenght = RemoveDuplicates(nums);

                Console.WriteLine("Długośc tablicy " + newLenght);

                Console.WriteLine("Tablica");
                for (int i = 0; i < newLenght; i++)
                {
                    Console.WriteLine(nums[i] + "");
                }
                Console.ReadKey();

            }
    }
}

