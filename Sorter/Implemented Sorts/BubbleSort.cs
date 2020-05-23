namespace Sorter.Implemented_Sorts
{
    public class BubbleSort : Sorter
    {
        public BubbleSort(Order order) : base(order) { }

        protected override int Split(object[] array, int low, int high)
        {
            for (var ii = low; ii < high; ii++)
            {
                if (Order.GreaterThan(array[ii], array[ii + 1]))
                {
                    Swap(array, ii, ii + 1);
                }
            }

            return high;
        }

        protected override void Join(object[] array, int low, int splitIndex, int high)
        {
            // Do nothing
        }
    }
}