using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

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
            testList.Add(1);
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
            actual = testList[1];

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

    }
}















        // Act (callmethod)

        // CustomListClass customList = new CustomListClass();
        // customList.Add();


        // Assert
        // Assert.AreEqual(1, 2);
    
    

