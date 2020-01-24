using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomTestMethods
{
    [TestClass]
    public class SubtractionTest
    {
        [TestMethod]
        public void RemovingUnitCountToNull()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int expected = 0;
            //Act
            myList.Add(value);
            myList.Remove(value);
            int actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void RemovingUnitCound()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
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
        public void RemovingFromListShorteningCapacity()
        {

            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueone = 1;
            int valuetwo = 2;
            int valuethree = 3;
            int valuefour = 4;
            int valuefive = 5;
            int expected = 4;
            //Act
            myList.Add(valueone);
            myList.Add(valuetwo);
            myList.Add(valuethree);
            myList.Add(valuefour);
            myList.Add(valuefive);
            myList.Remove(valuefive);
            int actual = myList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void RemovingPreviousUnitIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
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
        public void RemovingUnitAfterIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
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
        public void RemovingSameValueUnitFromList()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int valuetwo = 2;
            int valuethree = 1;
            int expected = 2;

            myList.Add(value);
            myList.Add(valuetwo);
            myList.Remove(value);
            int actual = myList[0];

            Assert.AreEqual(expected, actual);
        }
    }
}
