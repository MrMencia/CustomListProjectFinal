using System;
using CustomList;

namespace CustomListTest
{
    public class Program
    {
        public Program()
        {
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList.Count;
        }
    }
}
