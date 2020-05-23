using System;
using System.Collections.Generic;

namespace Sorter.Implemented_Sorts
{
    public class QuickSort : Sorter
    {
        public QuickSort(Order order) : base(order) { }

        protected override int Split(object[] array, int low, int high)
        {
            // Select a pivot
            var pivot = array[high];

            // Get initial index of smaller side
            var ii = low;
            
            // Begin swapping elements to ensure those less than the pivot are to the left
            // and those greater than or equal to the pivot are on the right
            for (var jj = low; jj < high; jj++)
            {
                if (!Order.LessThan(array[jj], pivot)) continue;
                
                Swap(array, ii, jj);
                ii++;
            }

            Swap(array, ii, high);
            return ii;
        }

        protected override void Join(object[] array, int low, int splitIndex, int high)
        {
            // Do nothing
        }
    }
}