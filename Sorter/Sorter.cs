using System;

namespace Sorter
{
    public abstract class Sorter
    {
        protected readonly Order Order;
        
        protected Sorter(Order order)
        {
            Order = order;
        }

        public void Sort(object[] array, int low, int high)
        {
            if (low >= high) return;
            
            var splitIndex = Split(array, low, high);
            Sort(array, low, splitIndex - 1);
            Sort(array, splitIndex, high);
            Join(array, low, splitIndex, high);
        }

        protected abstract int Split(object[] array, int low, int high);
        protected abstract void Join(object[] array, int low, int splitIndex, int high);
    }
}