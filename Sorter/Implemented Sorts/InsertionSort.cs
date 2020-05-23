namespace Sorter.Implemented_Sorts
{
    public class InsertionSort : Sorter
    {
        public InsertionSort(Order order) : base(order) { }

        protected override int Split(object[] array, int low, int high)
        {
            return high;
        }

        protected override void Join(object[] array, int low, int splitIndex, int high)
        {
            int jj;
            var key = array[high]; // Pick the last element in the array to insert
            
            // Begin shuffling any elements larger than the key over to the right
            for (jj = high; low < jj && Order.LessThan(key, array[jj - 1]); jj--)
            {
                array[jj] = array[jj - 1];
            }
            
            array[jj] = key; // Insert the key at it's final position
        }
    }
}