using System.Collections;
using System.Threading.Tasks;

namespace Sorter.Implemented_Sorts
{
    public class HeapSort : Sorter
    {
        public HeapSort(Order order) : base(order) { }

        protected override async Task<int> Split(IList list, int low, int high)
        {
            await Swap(list, low, high);
            await MinHeapify(list, low, high - 1);
            return high;
        }

        private async Task MinHeapify(IList list, int ii, int heapSize)
        {
            await Task.Delay(1);
            var smallest = ii;
            var leftChild = ii * 2 + 1;
            var rightChild = ii * 2 + 2;

            if (leftChild <= heapSize && Order.LessThan(list[leftChild], list[smallest])) smallest = leftChild;
            if (rightChild <= heapSize && Order.LessThan(list[rightChild], list[smallest])) smallest = rightChild;

            if (smallest != ii)
            {
                await Swap(list, ii, smallest);
                await MinHeapify(list, smallest, heapSize);
            }
        }

        protected override Task Join(IList list, int low, int splitIndex, int high)
        {
            // Do nothing
            return Task.CompletedTask;
        }
    }
}