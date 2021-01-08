using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Generics.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void Can_Add_After()
        {
            var linkedList = new LinkedList<string>();

            linkedList.AddFirst("Hello");
            linkedList.AddFirst("folks");
            linkedList.AddAfter(linkedList.First, "there");

            var expected = "there";
            var actual = linkedList.First.Next.Value;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Remove_Last()
        {
            var linkedList = new LinkedList<string>();

            linkedList.AddFirst("Hello");
            linkedList.AddFirst("folks");
            linkedList.RemoveLast();

            Assert.True(linkedList.First == linkedList.Last);
        }

        [Fact]
        public void Can_Find_Itens()
        {
            var linkedList = new LinkedList<string>();

            linkedList.AddFirst("This");
            linkedList.AddFirst("page");
            linkedList.AddFirst("intentionally");
            linkedList.AddFirst("left");
            linkedList.AddFirst("blank");

            Assert.Contains("page", linkedList);
        }
    }
}
