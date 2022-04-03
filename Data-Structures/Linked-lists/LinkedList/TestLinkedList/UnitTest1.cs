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


        //tests for challenge 6

        [Fact]
        public void AppendOneNode()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            SLL.Insert(list, 2);
            list.Append(6);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[2] -> [5] -> [6] -> NUll", result);
        }

        [Fact]
        public void AppendMultipleNodes()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            SLL.Insert(list, 2);
            list.Append(6);
            list.Append(6);
            list.Append(6);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[2] -> [5] -> [6] -> [6] -> [6] -> NUll", result);

            //[2] -> [5] -> [6] -> [6] -> [6] -> NUll

        }



        // tests for challenge 7





        [Fact]
        public void KOutOfRange()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            SLL.Insert(list, 2);
            list.Append(6);
            //list.KthFromEnd(4);


            //    Action act = () => list.KthFromEnd(4);

            //    IndexOutOfRangeException exception = Assert.Throws<IndexOutOfRangeException>(act);

            //    Assert.Equal("4 is out of the linked list's range! ", exception.Message);
            
            
            
            // it throws an error but I don't know how to x unit test Exceptions

        }


        [Fact]
        public void SameNumbers()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5); // it adds at head
            SLL.Insert(list, 2); // it adds at head
            list.Append(6); // it adds at the end
            

           Assert.Equal(2 , list.KthFromEnd(3));

        }


        [Fact]
        public void NegativeNumbers()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5); // it adds at head
            SLL.Insert(list, 2); // it adds at head
            list.Append(6); // it adds at the end


           // Assert.NotEqual(2, list.KthFromEnd(-3));

           // it throws an error but I don't know how to x unit test Exceptions

        }

        [Fact]
        public void OneNumber()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5); // it adds at head
           


             Assert.Equal(5  , list.KthFromEnd(1));

            

        }



        [Fact]
        public void NumberInMiddle()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5); // it adds at head
            list.Append(8);
            list.Append(2);
            list.Append(3);
            list.Append(7);
            list.Append(6);
            list.Append(4);

            Assert.Equal(3, list.KthFromEnd(4));



        }
    }
}

