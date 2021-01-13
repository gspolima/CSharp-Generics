using System;
using Xunit;
using DataStructures;

namespace DataStructures.Tests
{
    public class CircularBufferTests
    {
        [Fact]
        public void New_Buffer_Is_Empty()
        {
            var circularBuffer = new CircularBuffer<int>();

            Assert.True(circularBuffer.IsEmpty);
        }

        [Fact]
        public void Three_Sized_Buffer_Is_Full_After_Three_Writes()
        {
            var circularBuffer = new CircularBuffer<int>(3);

            circularBuffer.Write(4);
            circularBuffer.Write(2);
            circularBuffer.Write(8);

            Assert.True(circularBuffer.IsFull);
        }


        [Fact]
        public void First_In_First_Out_When_Not_Full()
        {
            var circularBuffer = new CircularBuffer<double>(4);
            var value1 = 14.5;
            var value2 = 10.0;

            circularBuffer.Write(value1);
            circularBuffer.Write(value2);

            Assert.Equal(value1, circularBuffer.Read());
            Assert.Equal(value2, circularBuffer.Read());
            Assert.True(circularBuffer.IsEmpty);
        }


        [Fact]
        public void Overwrites_When_More_Than_Capacity()
        {
            var circularBuffer = new CircularBuffer<int>(4);
            var values = new[] { 1, 2, 3, 4, 5, 6, 7 };

            foreach (var value in values)
            {
                circularBuffer.Write(value);
            }

            Assert.True(circularBuffer.IsFull);
            Assert.Equal(values[3], circularBuffer.Read());
            Assert.Equal(values[4], circularBuffer.Read());
            Assert.Equal(values[5], circularBuffer.Read());
            Assert.Equal(values[6], circularBuffer.Read());
            Assert.True(circularBuffer.IsEmpty);
        }
    }
}
