using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListFramework;

namespace CustomTestMethods
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ConvertFromIntToString()
        {
            //Arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value = 5;
            string expectedresult = "5";
            //Act
            myList.Add(value);
            string actualresult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void ConvertFromStringToString()
        {
            //Arrange
            MyCustomList<string> myList = new MyCustomList<string>();
            string value = "5";
            string valueTwo = "Hello";
            string expectedresult = "5Hello";
            //Act
            myList.Add(value);
            myList.Add(valueTwo);
            string actualresult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void ConvertMultipleIntsToString()
        {
            //Arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value = 5;
            int valueTwo = 7;
            string expectedresult = "57";
            //Act
            myList.Add(value);
            myList.Add(valueTwo);
            string actualresult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}
