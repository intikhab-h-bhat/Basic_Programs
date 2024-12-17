using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.Searchprogram
{
    public class BinarySearch
    {

        public int BinarSearhDemo(int[] arr,int len,int number)
        {
            int left = 0;
            int right = len-1;

            while (left <right)
            {
                int mid = left + right / 2;
                if (number == arr[mid])
                {
                    return mid;
                }
                else if (number < arr[mid])
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }


    }
}
