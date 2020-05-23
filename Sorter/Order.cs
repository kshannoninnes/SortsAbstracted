namespace Sorter
{
    public abstract class Order
    {
        public bool NotEqual(object x, object y)
        {
            return !Equal(x, y);
        }

        public bool LessThanOrEqual(object x, object y)
        {
            return LessThan(x, y) || Equal(x, y);
        }

        public bool GreaterThan(object x, object y)
        {
            return !LessThanOrEqual(x, y);
        }

        public bool GreaterThanOrEqual(object x, object y)
        {
            return !LessThan(x, y);
        }
        
        public abstract bool LessThan(object x, object y);
        public abstract bool Equal(object x, object y);
    }
}