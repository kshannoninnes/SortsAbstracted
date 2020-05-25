using System.Collections;
using System.Threading.Tasks;

namespace Sorter.Implemented_Sorts
{
    public class HeapSort : Sorter
    {
        public HeapSort(Order order) : base(order) { }

        protected override async Task<int> Split(IList list, int low, int high)
        {
            if (high == list.Count - 1) // If this is the first time splitting
            {
                // Build Max Heap
                for (var ii = high / 2 - 1; ii >= 0; ii--)
                    await MaxHeapify(list, high, ii);
            }
            
            await Swap(list, low, high);
            await MaxHeapify(list, high - 1, low);
            return high;
        }

        private async Task MaxHeapify(IList list, int n, int ii)
        {
            await Task.Delay(1); // Animation purposes
            
            var largest = ii;
            var leftChild = ii * 2 + 1;
            var rightChild = ii * 2 + 2;

            if (leftChild <= n && Order.GreaterThan(list[leftChild], list[largest])) largest = leftChild;
            if (rightChild <= n && Order.GreaterThan(list[rightChild], list[largest])) largest = rightChild;

            if (largest != ii)
            {
                await Swap(list, ii, largest);
                await MaxHeapify(list, n, largest);
            }
        }

        protected override Task Join(IList list, int low, int splitIndex, int high)
        {
            // Do nothing
            return Task.CompletedTask;
        }
    }
}