using System;
using System.Collections.Generic;

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

        protected void Swap(IList<object> array, int x, int y)
        {
            var temp = (int)array[x];
            array[x] = array[y];
            array[y] = temp;
        }

        protected abstract int Split(object[] array, int low, int high);
        protected abstract void Join(object[] array, int low, int splitIndex, int high);
    }
}