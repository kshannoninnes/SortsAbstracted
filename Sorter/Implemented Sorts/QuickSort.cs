using System;
using System.Collections.Generic;

namespace Sorter.Implemented_Sorts
{
    public class QuickSort : Sorter
    {
        public QuickSort(Order order) : base(order) { }

        protected override int Split(object[] array, int low, int high)
        {
            var pivot = array[high];

            var ii = low - 1;
            for (var jj = low; jj < high; jj++)
            {
                if (!Order.LessThan(array[jj], pivot)) continue;
                
                ii++;
                Swap(array, ii, jj);
            }

            Swap(array, ii + 1, high);
            return ii + 1;
        }

        protected override void Join(object[] array, int low, int splitIndex, int high)
        {
            // Do nothing
        }
    }
}