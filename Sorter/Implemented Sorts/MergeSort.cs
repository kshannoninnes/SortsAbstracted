using System.Collections;
using System.Threading.Tasks;

namespace Sorter.Implemented_Sorts
{
    public class MergeSort : Sorter
    {
        public MergeSort(Order order) : base(order) { }

        protected override async Task<int> Split(IList list, int low, int high)
        {
            var length = low + high;
            
            // Account for integer division with evens/odds
            return await Task.FromResult((length / 2) + (length % 2));
        }

        protected override async Task Join(IList list, int low, int splitIndex, int high)
        {
            // Find sizes of two subarrays to be merged 
            int n1 = splitIndex - low; 
            int n2 = high - splitIndex + 1; 
  
            // Create temp arrays
            var left = new object[n1]; 
            var right = new object[n2]; 
  
            // Copy data to temp arrays to prevent overriding data in array
            for (var ii = 0; ii < n1; ++ii) 
                left[ii] = list[low + ii]; 
            for (var jj = 0; jj < n2; ++jj) 
                right[jj] = list[splitIndex + jj];

            // Initial indexes of first and second subarrays 
            int i = 0, j = 0; 
  
            // Initial index of 'array' where first and second will merge to
            var k = low; 
            
            // Begin merging the two temp arrays into 'array' starting at index k
            while (i < n1 && j < n2) 
            { 
                await Task.Delay(1);
                if (Order.LessThanOrEqual(left[i], right[j])) 
                { 
                    list[k] = left[i]; 
                    i++; 
                } 
                else
                { 
                    list[k] = right[j]; 
                    j++; 
                } 
                k++; 
            } 
  
            // Copy remaining elements of left[] if any 
            while (i < n1) 
            { 
                list[k] = left[i]; 
                i++; 
                k++; 
            } 
  
            // Copy remaining elements of right[] if any
            while (j < n2) 
            { 
                list[k] = right[j]; 
                j++; 
                k++; 
            }
        }
    }
}