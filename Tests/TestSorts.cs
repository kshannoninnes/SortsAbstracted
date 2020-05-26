using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Sorter.Implemented_Orders;
using Sorter.Implemented_Sorts;

namespace Tests
{
    public abstract class TestSorts
    {
        protected Sorter.AbstractSort TestAbstractSort;
        private object[] _expected;

        [OneTimeSetUp]
        public Task OneTimeSetup()
        {
            _expected = new object[50];

            for (var ii = 0; ii < _expected.Length; ii++)
            {
                _expected[ii] = ii + 1;
            }
            
            return Task.CompletedTask;
        }

        [Test]
        public async Task Sort_ReverseSortedArray_IsSorted()
        {
            var input = new object[_expected.Length];
            Array.Copy(_expected, input, _expected.Length);
            Array.Reverse(input);
            
            var timer = new Stopwatch();
            timer.Start();
            await TestAbstractSort.Sort(input, 0, input.Length - 1);
            timer.Stop();
            
            Console.WriteLine($"Test running time: {timer.Elapsed}");
            Assert.AreEqual(_expected, input);
        }

        [Test]
        public async Task Sort_PreSortedArray_IsSorted()
        {
            var input = new object[_expected.Length];
            Array.Copy(_expected, input, _expected.Length);
            
            var timer = new Stopwatch();
            timer.Start();
            await TestAbstractSort.Sort(input, 0, input.Length - 1);
            timer.Stop();
            
            Console.WriteLine($"Test running time: {timer.Elapsed}");
            Assert.AreEqual(_expected, input);
        }

        [Test]
        public async Task Sort_RandomlySortedArray_IsSorted()
        {
            var rand = new Random();
            var input = new object[_expected.Length];
            Array.Copy(_expected, input, _expected.Length);
            input = input.OrderBy(x => rand.Next()).ToArray();
            
            var timer = new Stopwatch();
            timer.Start();
            await TestAbstractSort.Sort(input, 0, input.Length - 1);
            timer.Stop();
            
            Console.WriteLine($"Test running time: {timer.Elapsed}");
            Assert.AreEqual(_expected, input);
        }
    }
}