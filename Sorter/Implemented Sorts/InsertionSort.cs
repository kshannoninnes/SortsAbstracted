using System.Collections;
using System.Threading.Tasks;

namespace Sorter.Implemented_Sorts
{
    public class InsertionSort : Sorter
    {
        public InsertionSort(Order order) : base(order) { }

        protected override Task<int> Split(IList list, int low, int high)
        {
            return Task.FromResult(high);
        }

        protected override async Task Join(IList list, int low, int splitIndex, int high)
        {
            int jj;
            var key = list[high]; // Pick the last element in the array to insert
            
            // Begin shuffling any elements larger than the key over to the right
            for (jj = high; low < jj && Order.LessThan(key, list[jj - 1]); jj--)
            {
                await Task.Delay(1);
                list[jj] = list[jj - 1];
            }
            
            list[jj] = key; // Insert the key at it's final position
        }
    }
}