using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Generics.Tests
{
    public class StackTests
    {
        [Fact]
        public void Can_Peek_At_Next_Item_Without_Removing()
        {
            var stack = new Stack<int>();

            stack.Push(70);
            stack.Push(14);
            stack.Push(55);

            var expected = 55;
            var actual = stack.Peek();
            Assert.Equal(3, stack.Count);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Search_With_Contains()
        {
            var stack = new Stack<int>();

            stack.Push(70);
            stack.Push(14);
            stack.Push(55);

            Assert.True(stack.Contains(70));
        }

        [Fact]
        public void Can_Convert_To_Array()
        {
            var stack = new Stack<int>();

            stack.Push(70);
            stack.Push(14);
            stack.Push(55);

            var expected = 70;
            var stackAsArray = stack.ToArray();
            Assert.Equal(expected, stackAsArray[2]);
        }
    }
}
