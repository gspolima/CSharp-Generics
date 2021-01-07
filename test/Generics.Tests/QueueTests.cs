using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Collections;

namespace Generics.Tests
{
    public class QueueTests
    {
        [Fact]
        public void Can_Peek_At_Next_Item()
        {
            var queue = new Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(85);

            var expected = 5;
            var actual = queue.Peek();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Search_With_Contains()
        {
            var queue = new Queue<int>();

            queue.Enqueue(51);
            queue.Enqueue(43);
            queue.Enqueue(97);

            Assert.True(queue.Contains(43));
        }

        [Fact]
        public void Can_Convert_Queue_To_Array()
        {
            var queue = new Queue<int>();

            queue.Enqueue(12);
            queue.Enqueue(74);
            queue.Enqueue(38);

            var expected = 74;
            var queueAsArray = queue.ToArray();
            queue.Dequeue();

            Assert.Equal(expected, queueAsArray[1]);
            Assert.True(queue.Count == 2);
        }


        [Fact]
        public void Queue_Can_Insert()
        {
            var line = new Queue<Employee>();

            line.Enqueue(new Employee() { Name = "George" });
            line.Enqueue(new Employee() { Name = "Julia" });

            var expected = 2;
            var actual = line.Count;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Queue_Can_Remove()
        {
            var line = new Queue<Employee>();

            line.Enqueue(new Employee() { Name = "George" });
            line.Enqueue(new Employee() { Name = "Julia" });
            line.Enqueue(new Employee() { Name = "Sadie" });
            line.Dequeue();
            line.Dequeue();

            var expected = 1;
            var actual = line.Count;
            Assert.Equal(expected, actual);
        }
    }
}
