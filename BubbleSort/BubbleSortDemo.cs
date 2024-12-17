using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.BubbleSort
{
    public class BubbleSortDemo
    {



        //public void BubbleSort(int[] numbers)
        //{
        //    int len=numbers.Length;

        //    for (int i=0; i<len-1; i++)
        //    {
        //        for (int j = 0; j < len - i - 1;j++)
        //        {
        //            if (numbers[j]> numbers[j + 1])
        //            {
        //                int temp = numbers[j];
        //                numbers[j]= numbers[j + 1];
        //                numbers[j+1]= temp;

        //            }

        //        }


        //    }

        //}
        //public void PrintArray(int[] numbers)
        //{
        //    foreach (var n in numbers)
        //    {
        //        Console.Write($"{n},");
        //    }
        //    Console.WriteLine();
        //}


        public void BubbleSort(int[] arr)
        {
           int arrayLength=arr.Length;

            for(int i=0; i<arrayLength-1; i++) 
            { 
            for(int j=0;j<arrayLength-i-1; j++)
                {

                    if (arr[j]> arr[j + 1])
                    {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }             
                
                }
            
            
            }

        }


        public void PrintArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }

        }
      
           
    }
}
  