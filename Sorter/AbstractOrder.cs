namespace Sorter
{
    /// <summary>
    ///     An Order is a way of defining where two objects fall in an ordered set in relation
    ///     to each other, determined by the concrete implementations of Equal and LessThan.
    ///
    ///     This method is better than the alternative of implementing IComparable for custom
    ///     objects, as it allows the sorts to delegate the comparison operations to the Order
    ///     object that it has a reference to. This decreases coupling and eliminates the use
    ///     of instance checks, simply passing the objects to be compared to the Order object
    ///     and trusting that it can handle them internally. 
    /// </summary>
    public abstract class AbstractOrder
    {
        /// <summary>
        ///     Return true if the two objects are not equal, as defined by the Equal method
        /// </summary>
        public bool NotEqual(object x, object y)
        {
            return !Equal(x, y);
        }

        /// <summary>
        ///     Return true if the first object is less than or equal to the second object,
        ///     defined by the LessThan and Equal methods
        /// </summary>
        public bool LessThanOrEqual(object x, object y)
        {
            return LessThan(x, y) || Equal(x, y);
        }

        /// <summary>
        ///     Return true if the first object is greater than the second object, as defined
        ///     by the LessThanOrEqual method
        /// </summary>
        public bool GreaterThan(object x, object y)
        {
            return !LessThanOrEqual(x, y);
        }

        /// <summary>
        ///     Return true if the first object is greater than or equal to the second object,
        ///     as defined by the LessThan method
        /// </summary>
        public bool GreaterThanOrEqual(object x, object y)
        {
            return !LessThan(x, y);
        }
        
        public abstract bool LessThan(object x, object y);
        public abstract bool Equal(object x, object y);
    }
}