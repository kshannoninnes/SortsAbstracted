using NUnit.Framework;
using Sorter.Implemented_Orders;
using Sorter.Implemented_Sorts;

namespace Tests.Implemented_Tests
{
    public class TestQuickSort : TestSorts
    {
        [SetUp]
        public void Setup()
        {
            var ordering = new IntegerAbstractOrder();
            TestAbstractSort = new QuickSort(ordering);
        }
    }
}