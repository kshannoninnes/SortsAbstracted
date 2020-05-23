namespace Sorter.Implemented_Orders
{
    public class IntegerOrder : Order
    {
        public override bool LessThan(object x, object y)
        {
            return (int) x < (int) y;
        }

        public override bool Equal(object x, object y)
        {
            return (int) x == (int) y;
        }
    }
}