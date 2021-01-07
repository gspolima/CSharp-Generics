using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Generics.Tests
{
    public class HashSetTests
    {
        [Fact]
        public void Intersect_Sets()
        {
            var set1 = new HashSet<int>() { 2, 4, 6 };
            var set2 = new HashSet<int>() { 7, 6, 2 };

            set1.IntersectWith(set2);

            var expected = new HashSet<int>() { 2, 6 };
            Assert.Equal(expected, set1);
        }

        [Fact]
        public void Union_Sets()
        {
            var set1 = new HashSet<int>() { 2, 4, 6 };
            var set2 = new HashSet<int>() { 7, 6, 2 };

            set1.UnionWith(set2);

            var expected = new HashSet<int>() { 2, 4, 6, 7 };
            Assert.Equal(expected, set1);
        }

        [Fact]
        public void SymmetricExceptWith_Sets()
        {
            var set1 = new HashSet<int>() { 2, 4, 6 };
            var set2 = new HashSet<int>() { 7, 6, 2 };

            set1.SymmetricExceptWith(set2);

            var expected = new HashSet<int>() { 4, 7 };
            Assert.Equal(expected, set1);
        }
    }
}
