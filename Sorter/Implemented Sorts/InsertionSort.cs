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
            int j, key = (int)array[high];
            for (j = high; low < j && Order.LessThan(key, array[j-1]); j--)
            {
                array[j] = array[j - 1];
            }
            array[j] = key;
        }
    }
}