using System.Collections;
using System.Threading.Tasks;

namespace Sorter.Implemented_Sorts
{
    public class QuickSort : AbstractSort
    {
        public QuickSort(AbstractOrder abstractOrder) : base(abstractOrder) { }

        // Hoare Partition Scheme
        // https://en.wikipedia.org/wiki/Quicksort#Hoare_partition_scheme
        protected override async Task<int> Split(IList list, int low, int high)
        {
            // Select a pivot
            var pivot = list[(high + low) / 2];

            // Get initial index of smaller side
            var ii = low;
            var jj = high;

            // Begin swapping elements to ensure those less than the pivot are to the left
            // and those greater than or equal to the pivot are on the right
            while (true)
            {
                await Task.Delay(1);
                while (AbstractOrder.LessThan(list[ii], pivot))
                {
                    ii++;
                }

                while (AbstractOrder.GreaterThan(list[jj], pivot))
                {
                    jj--;
                }

                if (ii >= jj)
                {
                    return jj + 1; // +1 to account for base Sorter using -1 instead of +1 for the recursive calls
                }

                await Swap(list, ii, jj);
                ii++;
                jj--;
            }
        }

        protected override Task Join(IList list, int low, int splitIndex, int high)
        {
            // Do nothing
            return Task.CompletedTask;
        }
    }
}