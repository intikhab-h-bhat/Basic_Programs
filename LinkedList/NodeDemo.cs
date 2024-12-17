using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.LinkedList
{
    public class NodeDemo
    {

        public int Data { get; set; }

        public NodeDemo? Next { get; set; }

        public void DisplayData()
        {
            

            Console.WriteLine(Data);
        }
    }
}
