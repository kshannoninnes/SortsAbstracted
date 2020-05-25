﻿using System.Collections;
using System.Threading.Tasks;

namespace Sorter
{
    public abstract class AbstractSort
    {
        protected readonly AbstractOrder AbstractOrder;
        
        protected AbstractSort(AbstractOrder abstractOrder)
        {
            AbstractOrder = abstractOrder;
        }

        public async Task Sort(IList list, int low, int high)
        {
            if (low >= high) return;
            
            var splitIndex = await Split(list, low, high);
            await Sort(list, low, splitIndex - 1);
            await Sort(list, splitIndex, high);
            await Join(list, low, splitIndex, high);
        }

        protected Task Swap(IList list, int x, int y)
        {
            var temp = list[x];
            list[x] = list[y];
            list[y] = temp;

            return Task.CompletedTask;
        }

        protected abstract Task<int> Split(IList list, int low, int high);
        protected abstract Task Join(IList list, int low, int splitIndex, int high);
    }
}