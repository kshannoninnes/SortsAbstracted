namespace Sorter.Implemented_Orders
{
    public class IntegerOrder : AbstractOrder
    {
        /// <summary>
        ///     Return true if the first integer value is less than the second integer value
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool LessThan(object x, object y)
        {
            return (int) x < (int) y;
        }

        /// <summary>
        ///     Return true if the two integer values are equivalent
        /// </summary>
        public override bool Equal(object x, object y)
        {
            return (int) x == (int) y;
        }
    }
}