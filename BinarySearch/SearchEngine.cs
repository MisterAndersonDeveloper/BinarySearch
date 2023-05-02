using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal static class SearchEngine
    {
        public static int BinarySearch(int[] numbers, int target)
        {
            int low = 0, high = numbers.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (numbers[mid] == target)
                    return mid;
                else if (target < numbers[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1; //target doesn't exist int the array
        }
    }
}
