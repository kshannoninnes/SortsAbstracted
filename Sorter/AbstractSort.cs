using System.Collections;
using System.Threading.Tasks;

namespace Sorter
{
    /// <summary>
    ///     A Sort is a way of rearranging elements of a collection in a logical ordered
    ///     manner. Sorting a collection can be done with many strategies, all of which
    ///     can be implemented with a divide and conquer template method.
    /// </summary>
    public abstract class AbstractSort
    {
        protected readonly AbstractOrder AbstractOrder;
        
        protected AbstractSort(AbstractOrder abstractOrder)
        {
            AbstractOrder = abstractOrder;
        }

        /// <summary>
        ///     The Sort method is used to implement the overall Divide and Conquer algorithm.
        ///     Iteration is simulated by having the concrete sorts implement a Split algorithm
        ///     that ultimately returns either high or low, depending on whether it will iterate
        ///     from low-high or high-low.
        /// </summary>
        public async Task Sort(IList list, int low, int high)
        {
            if (low >= high) return;
            
            var splitIndex = await Split(list, low, high);
            await Sort(list, low, splitIndex - 1);
            await Sort(list, splitIndex, high);
            await Join(list, low, splitIndex, high);
        }

        /// <summary>
        ///     Helper method for swapping two elements of an IList
        /// </summary>
        protected void Swap(IList list, int x, int y)
        {
            var temp = list[x];
            list[x] = list[y];
            list[y] = temp;
        }

        protected abstract Task<int> Split(IList list, int low, int high);
        protected abstract Task Join(IList list, int low, int splitIndex, int high);
    }
}