using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> dataset)
        {
            Console.WriteLine("Sorting using Bubble Sort !");
            return dataset;
        }
    }
}
