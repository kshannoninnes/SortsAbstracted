using NUnit.Framework;
using Sorter.Implemented_Orders;
using Sorter.Implemented_Sorts;

namespace Tests.Implemented_Tests
{
    public class TestBubbleSort : TestSorts
    {
        [SetUp]
        public void Setup()
        {
            var ordering = new IntegerOrder();
            TestAbstractSort = new BubbleSort(ordering);
        }
    }
}