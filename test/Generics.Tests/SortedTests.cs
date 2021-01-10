using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Generics.Tests
{
    public class SortedTests
    {

        [Fact]
        public void Can_Use_SortedList()
        {
            var sortedList = new SortedList<int, string>();

            sortedList.Add(3, "Joe");
            sortedList.Add(1, "Jane");
            sortedList.Add(2, "Jason");

            var expected = 0;
            var actual = sortedList.IndexOfKey(1);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Can_Use_SortedSet()
        {
            var sortedDictionary = new SortedDictionary<int, string>();

            sortedDictionary.Add(3, "three");
            sortedDictionary.Add(1, "one");
            sortedDictionary.Add(2, "two");
            sortedDictionary.Add(4, "four");

            var enumerator = sortedDictionary.GetEnumerator();
            enumerator.MoveNext();
            enumerator.MoveNext();

            Assert.Equal(2, enumerator.Current.Key);
        }
    }
}
