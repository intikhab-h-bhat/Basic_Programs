using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.Factorial
{
    public class FactorialProg
    {

        public void FactorialDemo(int number)
        {
            int fact = 1;

            while(number > 0)
            {
                fact=fact* number;
                number--;
            }

            Console.WriteLine($"tha factorial of a {number} is {fact} ");



            
        }

    }
}
