using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListFramework;

namespace CustomTestMethods
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void RemovingUnitCountToNull()
        {
            //Arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value = 1;
            int expected = 0;
            //Act
            myList.Add(value);
            myList.Remove(value);
            int actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemovingUnitCount()
        {
            //Arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value = 1;
            int valuetwo = 2;
            int expected = 1;
            //Act
            myList.Add(value);
            myList.Add(valuetwo);
            myList.Remove(valuetwo);
            int actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemovingPreviousUnitIndex()
        {
            //Arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value = 1;
            int valuetwo = 2;
            int expected = 2;
            //Act
            myList.Add(value);
            myList.Add(valuetwo);
            myList.Remove(value);
            int actual = myList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemovingUnitAfterIndex()
        {
            //Arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value = 1;
            int valuetwo = 2;
            int valuethree = 3;
            int expected = 3;
            //Act
            myList.Add(value);
            myList.Add(valuetwo);
            myList.Add(valuethree);
            myList.Remove(valuetwo);
            int actual = myList[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemovingSameValueUnitFromList()
        {
            MyCustomList<int> myList = new MyCustomList<int>();
            int value = 1;
            int valuetwo = 2;
            int expected = 2;

            myList.Add(value);
            myList.Add(valuetwo);
            myList.Remove(value);
            int actual = myList[0];

            Assert.AreEqual(expected, actual);
        }
    }
}
