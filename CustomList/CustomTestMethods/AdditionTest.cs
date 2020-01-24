using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomTestMethods
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void CheckZeroIndexAdd()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expectedresult = 0;
            //Act
            myList.Add(value);
            int actualresult = myList[0];

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void CheckIndexAfterOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int valuetwo = 3;
            int expectedresult = 1;
            //Act
            myList.Add(value);
            myList.Add(valuetwo);
            int actualresult = myList[1];

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void CheckCountAfterAddingFromNull()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 4;
    
            //Act
            myList.Add(value);
            int expectedResult = 1;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void CheckCountAfterAddingMoreThanOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int valuetwo = 3;
            int expectedResult = 2;


            //Act
            myList.Add(value);
            myList.Add(valuetwo);
            int actualResult = myList.Count;


            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void AddCapacityOnceFull()
        {
            CustomList<int> myList = new CustomList<int>();
            int valueone = 1;
            int valuetwo = 2;
            int valuethree = 3;
            int valuefour = 4;
            int valuefive = 5;
            int expectedResult = 8;

            myList.Add(valueone);
            myList.Add(valuetwo);
            myList.Add(valuethree);
            myList.Add(valuefour);
            myList.Add(valuefive);
            int actualResult = myList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
