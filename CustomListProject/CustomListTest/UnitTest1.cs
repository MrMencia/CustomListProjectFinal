using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // Arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(expected);
            actual = testList[0];

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToOne()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(6);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Add_AddFiveToEmptyList_CountGoesToFive()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 5;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList.Count;

            // assert

            Assert.AreEqual(expected, actual);
        }
        // write a test for when the array size changes (what is you array's starting size?)





//Remove Test Methods

        [TestMethod]
        public void Remove_RemoveFromEmptyList_ItemGoesToIndexZero()
        {
            // Arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Remove(2);
            actual = testList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ValueInList_ValueIsRemoved()
        {
            // Arrange
            CustomListClass<int> i = new CustomListClass<int>();
            i.Add(0);
            i.Add(1);
            i.Add(2);
            i.Add(3);
            i.Add(4);

            // Act
            i.Remove(2);

            // Assert
            int expected = 3;
            int actual = i[2];
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Remove_ValueNotInList_ListCountRemainsUnchanged()
        {
            // Arrange
            CustomListClass<int> i = new CustomListClass<int>();
            i.Add(0);
            i.Add(1);
            i.Add(2);
            i.Add(3);
            i.Add(4);
            int expected = 5;

            // Act
            i.Remove(5);

            // Assert
            int actual = i.Count;
            Assert.AreEqual(expected, actual);
        }

        //ToString
        [TestMethod]
        public void ToString_MultipleItemsInList_OutputCSVString()
        {
            // Arrange
            int itemsToAdd = 10;
            string expected = "{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }";
            CustomListClass<int> d = new CustomListClass<int>();
            for (int i = 0; i < itemsToAdd; i++)
            {
                d.Add(i);
            }

            // Act
            string actual = d.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ToString_NoItemsInList_EmptyString()
        {
            // Arrange
            string expected = " ";

            CustomListClass<int> d = new CustomListClass<int>();

            // Act
            string actual = d.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }


    //Overload +
    [TestMethod]
    public void AddTwoListsTogether_StringHasCorrectValues()
    {
        //Arrange
        CustomListClass<int> testListOne = new CustomListClass<int>();

        testListOne.Add(121);
        testListOne.Add(233);
        testListOne.Add(344);
        testListOne.Add(455);

        CustomListClass<int> testListTwo = new CustomListClass<int>();

        testListTwo.Add(566);
        testListTwo.Add(677);
        testListTwo.Add(788);
        testListTwo.Add(899);
        string expected = "111, 222, 333, 444, 555, 666, 777, 888";
        string actual;

        //Act
        CustomListClass<int> result = testListOne + testListTwo;
        actual = result.ToString();

        //Assert
        Assert.AreEqual(expected, actual);
    }


    //Overload -

    [TestMethod]
    public void SubtractLists_SubtractOneListFromAnother_ListHasCorrectValues()
    {
        //Arrange
        CustomListClass<int> testListOne = new CustomListClass<int>();
        testListOne.Add(121);
        testListOne.Add(242);
        testListOne.Add(258);
        testListOne.Add(436);
        CustomListClass<int> testListTwo = new CustomListClass<int>();
        testListTwo.Add(143);
        testListTwo.Add(654);
        testListTwo.Add(764);
        testListTwo.Add(346);
        string expected = "222, 444, 232, 454";
        string actual;

        //Act
        CustomListClass<int> result = testListOne - testListTwo;
        actual = result.ToString();

        //Assert
        Assert.AreEqual(expected, actual);
    }


    // Zip
    [TestMethod]
    public void Zip_ZipTwoListsTogether_ListHasCorrectValues()
    {
        //Arrange
        CustomListClass<int> testListOne = new CustomListClass<int>();
        testListOne.Add(111);
        testListOne.Add(222);
        testListOne.Add(333);
        CustomListClass<int> testListTwo = new CustomListClass<int>();
        testListTwo.Add(444);
        testListTwo.Add(555);
        testListTwo.Add(666);
        string expected = "111, 444, 222, 555, 333, 666";
        string actual;

        //Act
        actual = CustomListClass<int>.Zip(testListOne, testListTwo).ToString();

        //Assert
        Assert.AreEqual(expected, actual);
    }

}















        // Act (callmethod)

        // CustomListClass customList = new CustomListClass();
        // customList.Add();


        // Assert
        // Assert.AreEqual(1, 2);
    
    

