using System;
using System.Collections.Generic;
using Xunit;

namespace Generics.Tests
{
    public class ListTests
    {
        [Fact]
        public void List_Can_Insert()
        {
            var integers = new List<int>() { 4, 2, 0 };

            integers.Add(6);
            integers.Add(9);

            var expected = 6;
            Assert.Equal(expected, integers[3]);
        }

        [Fact]
        public void List_Can_Remove()
        {
            var integers = new List<int>() { 4, 8, 2 };

            integers.Remove(8);

            var expected = new List<int>() { 4, 2 };
            Assert.Equal(expected, integers);
        }

        [Fact]
        public void List_Find_Things()
        {
            var integers = new List<int>() { 1, 3, 5 };

            var expected = 2;
            var actual = integers.IndexOf(5);
            Assert.Equal(expected, actual);
        }
    }
}
