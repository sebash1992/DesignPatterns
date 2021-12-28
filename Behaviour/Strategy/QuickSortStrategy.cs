using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class QuickSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> dataset)
        {
            Console.WriteLine("Sorting using Quick Sort !");
            return dataset;
        }
    }
}
