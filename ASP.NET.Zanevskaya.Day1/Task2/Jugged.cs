using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Library;

namespace Task2
{
    class Jugged
    {
        static void Main()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 10, 5, 7, 3, 87 };
            jaggedArray[1] = new int[] { 5, 1, 12, 12, 0, 9, 8 };
            jaggedArray[2] = new int[] { 1, 3, 2, 85 };

            jaggedArray = JaggedSort.SortArrayMax(jaggedArray);
            jaggedArray = JaggedSort.SortArrayMin(jaggedArray);
            jaggedArray = JaggedSort.SortSumElem(jaggedArray);
        }
    }
}
