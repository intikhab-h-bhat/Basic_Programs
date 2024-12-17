using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.QuiskSort
{
    public class QuickSort
    {

        public void QuickSortDemo(int[] arr, int lb, int hb)
        {

            if (lb < hb)
            {

                int loc = PartionList(arr, lb, hb);

                QuickSortDemo(arr, lb, loc - 1);
                QuickSortDemo(arr, loc + 1, hb);

            }


        }

        public int PartionList(int[] arr, int lb, int hb)
        {
            int pivot = arr[hb];
            int i = lb - 1;

            for(int j = lb;j<hb;j++)
            {
                if (arr[j]< pivot)
                {
                    i++;

                    Swap(arr, i, j);
                }
            }

            Swap(arr, i+1, hb);
            return i + 1;
        }

        public void Swap(int[] arr,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }

        public void PrintArrayList(int[] arr)
        {
            Console.WriteLine(string.Join(",", arr));
        }














        //public void QuickSortDemo(int[] arr, int lb, int hb)
        //{
        //    if (lb < hb)
        //    {
        //        int loc = Partition(arr, lb, hb);

        //        QuickSortDemo(arr, lb, loc - 1);
        //        QuickSortDemo(arr,loc + 1,hb);
        //    }

        //}

        //public int Partition(int[] arr, int lb, int hb)
        //{
        //    int pivot = arr[hb];
        //    int i = lb - 1;

        //    for(int j=lb;j<hb;j++)
        //    {
        //        if (arr[j]< pivot)
        //        {
        //            i++;
        //            Swap(arr,i,j);
        //        }

        //    }
        //    Swap(arr,i+1,hb);

        //    return i+1;
        //}
        //public void Swap(int[] arr, int i,int j)
        //{

        //    int temp = arr[i];
        //    arr[i] = arr[j];
        //    arr[j] = temp;

        //}

        //public void PrintArray(int[] arr)
        //{
        //    Console.WriteLine(string.Join(", ", arr));
        //}


    }
}
