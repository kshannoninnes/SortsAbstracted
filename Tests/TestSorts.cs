using System;
using System.Linq;
using NUnit.Framework;
using Sorter.Implemented_Orders;
using Sorter.Implemented_Sorts;

namespace Tests
{
    public abstract class TestSorts
    {
        protected Sorter.Sorter TestSorter;

        [Test]
        public void Sort_ReverseSortedArray_IsSorted()
        {
            var input = new object[] {5, 4, 3, 2, 1};
            var expected = new object[] {1, 2, 3, 4, 5};
            
            TestSorter.Sort(input, 0, 4);
            Assert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_PreSortedArray_IsSorted()
        {
            var input = new object[] {1, 2, 3, 4, 5};
            var expected = new object[] {1, 2, 3, 4, 5};
            
            TestSorter.Sort(input, 0, 4);
            Assert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_RandomlySortedArray_IsSorted()
        {
            var rand = new Random();
            var input = new object[] {1, 2, 3, 4, 5};
            input = input.OrderBy(x => rand.Next()).ToArray();
            var expected = new object[] {1, 2, 3, 4, 5};
            
            TestSorter.Sort(input, 0, 4);
            Assert.AreEqual(expected, input);
        }
    }
}