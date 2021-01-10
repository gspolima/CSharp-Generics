using Collections;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Generics.Tests
{
    

    public class DictionaryTests
    {
        [Fact]
        public void Can_Use_Dict_As_Map()
        {
            var dictionaryMap = new Dictionary<int, string>();

            dictionaryMap.Add(1, "One");
            dictionaryMap.Add(2, "Two");
            dictionaryMap.Add(3, "Three");
            dictionaryMap.Add(4, "Four");

            var expected = "Two";
            var actual = dictionaryMap[2];
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Search_By_Key_With_Contains()
        {
            var dictionary = new Dictionary<int, Employee>();

            dictionary.Add(1, new Employee() { Name = "Scott" });
            dictionary.Add(2, new Employee() { Name = "John" });

            var actual = dictionary.ContainsKey(2);
            Assert.True(actual);
        }

        [Fact]
        public void Can_Remove_By_Key()
        {
            var releaseDictionary = new Dictionary<int, string>();
            releaseDictionary.Add(1, "16.7.4");
            releaseDictionary.Add(2, "16.8.1");
            releaseDictionary.Add(3, "16.8.3");

            releaseDictionary.Remove(1);

            var expected = 2;
            var actual = releaseDictionary.Count;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Search_By_Value()
        {
            var cats = new Dictionary<int, string>();

            cats.Add(1, "Gandalf");
            cats.Add(2, "Zelda");
            cats.Add(3, "Diamante");
            cats.Add(4, "Star");

            var actual = cats.ContainsValue("Zelda");
            Assert.True(actual);
        }

        [Fact]
        public void Throws_Exception_If_Duplicate_Key()
        {
            var dictionary = new Dictionary<int, DateTime>();
            
            dictionary.Add(1, new DateTime(day: 19, month: 03, year: 2002));

            Assert.Throws<ArgumentException>(() => 
                dictionary.Add(1, new DateTime(1957, 01, 07)));
        }
    }
}
