using System;
using Xunit;
using LinkedList;

namespace TestLinkedList
{
    
    public class UnitTest1
    {
        [Fact]
        public void EmptyInstantiation()
        {
            SLL list = new SLL();

            Assert.Equal(null, list.head);
        }

        [Fact]
        public void Insert()
        {
            SLL list = new SLL();
            SLL.Insert(list, 8);

            Assert.Equal(8, list.head.value);
        }

        [Fact]
        public void PointAtHead()
        {
            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 10);
            SLL.Insert(list, 1);
            SLL.Insert(list, 2);

            Assert.Equal(2, list.head.value);

        }

        [Fact]
        public void InsertMultipleNodes()
        {

            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 10);
            SLL.Insert(list, 1);
            SLL.Insert(list, 2);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[2] -> [1] -> [10] -> [8] -> NUll", result);

        }

        [Fact]
        public void FindValue()
        {
            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 10);
            SLL.Insert(list, 1);
            SLL.Insert(list, 2);

            Assert.Equal(true, SLL.Includes(list, 10));

        }

        [Fact]
        public void ValueNotFound()
        {
            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 10);
            SLL.Insert(list, 1);
            SLL.Insert(list, 2);

            Assert.Equal(false, SLL.Includes(list, 100));

        }

        [Fact]
        public void RetunValues()
        {

            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 7);
            SLL.Insert(list, 6);
            SLL.Insert(list, 5);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[5] -> [6] -> [7] -> [8] -> NUll", result);

        }
    }
}
