using NUnit.Framework;
using Sorter.Implemented_Orders;
using Sorter.Implemented_Sorts;

namespace Tests.Implemented_Tests
{
    public class TestInsertionSort : TestSorts
    {
        [SetUp]
        public void Setup()
        {
            var ordering = new IntegerOrder();
            TestSorter = new InsertionSort(ordering);
        }
    }
}