using System.Collections;
using System.Threading.Tasks;

namespace Sorter.Implemented_Sorts
{
    public class BubbleSort : AbstractSort
    {
        public BubbleSort(AbstractOrder abstractOrder) : base(abstractOrder) { }

        protected override async Task<int> Split(IList list, int low, int high)
        {
            // Bubble the largest element in the array up to the last position
            for (var ii = low; ii < high; ii++)
            {
                await Task.Delay(1);
                if (!AbstractOrder.GreaterThan(list[ii], list[ii + 1])) continue;
                Swap(list, ii, ii + 1);
            }
            return high;
        }

        protected override Task Join(IList list, int low, int splitIndex, int high)
        {
            // Do nothing
            return Task.CompletedTask;
        }
    }
}