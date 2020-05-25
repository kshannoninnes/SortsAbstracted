using System;

namespace Sorter.Implemented_Orders
{
    public class DoubleAbstractOrder: AbstractOrder
    {
        /// <summary>
        ///     Return true if the first double parameter is less than the second double parameter
        /// </summary>
        public override bool LessThan(object x, object y)
        {
            return (double) x < (double) y;
        }

        /// <summary>
        ///     Return true if the two double values are equal to a precision of 9 digits after the decimal point
        /// </summary>
        public override bool Equal(object x, object y)
        {
            const double nineDigitPrecision = 0.000000001;
            return Math.Abs((double) x - (double) y) < nineDigitPrecision;
        }
    }
}