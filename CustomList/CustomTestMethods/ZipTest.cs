using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListFramework;

namespace CustomTestMethods
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void ZippingTwoArraysTogetherOfEqualLengths()
        {
            //Arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            MyCustomList<int> myListTwo = new MyCustomList<int>();
            int valueOddOne = 1;
            int valueOddTwo = 3;
            int valueOddThree = 5;
            int valueEvenOne = 2;
            int valueEvenTwo = 4;
            int valueEvenThree = 6;
            string expected = "123456";
            //Act
            myList.Add(valueOddOne);
            myList.Add(valueOddTwo);
            myList.Add(valueOddThree);
            myListTwo.Add(valueEvenOne);
            myListTwo.Add(valueEvenTwo);
            myListTwo.Add(valueEvenThree);
            string actual = MyCustomList<T>.Zip().ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZippingTwoArraysTogetherOfDifferentLengths()
        {
            //Arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            MyCustomList<int> myListTwo = new MyCustomList<int>();
            int valueOddOne = 1;
            int valueOddTwo = 3;
            int valueOddThree = 5;
            int valueOddFour = 7;
            int valueEvenOne = 2;
            int valueEvenTwo = 4;
            int valueEvenThree = 6;
            string expected = "1234567";
            //Act
            myList.Add(valueOddOne);
            myList.Add(valueOddTwo);
            myList.Add(valueOddThree);
            myList.Add(valueOddFour);
            myListTwo.Add(valueEvenOne);
            myListTwo.Add(valueEvenTwo);
            myListTwo.Add(valueEvenThree);
            string actual = MyCustomList<T>().ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
        
