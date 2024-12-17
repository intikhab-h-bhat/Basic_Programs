using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.Searchprogram
{
    public class LinearSearch
    {
        


        int[] linearSearch = [12, 13, 5, 17, 18, 19];
        int flag = 0;
       
        public void SearchElement(int number)
        {
            foreach (int i in linearSearch)
            {
                if(i == number)
                {
                    flag = 1;
                    break;
                }

            }
            if(flag == 1)
            {
                Console.WriteLine($"{number} is present in {linearSearch}");
            }
            else
            {
                Console.WriteLine($"{number} is not present in {linearSearch}");
            }
        }

    }
}
