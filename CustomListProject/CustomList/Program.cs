using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
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
            testList.Remove(3);
            actual = testList.Count;
        }
    }
}
