using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomListClass<T>: IEnumerable <T>
    {

        //member variables

        private T[] items;

        // property for Capacity



        public int Count { get; private set; }
        public int Capacity { get; set; }


        public T this[int i]
        {
            get
            {
                if (i >= Count || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[i];
            }
            set
            {
                if (i < Count && i >= 0)
                {
                    items[i] = value;
                }
                if (i >= Count || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }








        //Construcor (Is a.....)

        public CustomListClass()
        {
            Capacity = 4;
            Count = 0;
            items = new T[Capacity];

        }




        //Member Methods (Can do......)


        //Iterable


        //You need to have your CustomList class implement the IEnumerable interface.
        //The logic that goes inside the method implementation is a for loop and yield return.
        //The custom iterator lecture has some good examples of how this works.


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }





        public void Add(T item)
        {
            if(Count == Capacity)
            {
                Capacity *= 2;

                T[] temp = new T[Capacity];
                for(int i =0; i < Count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
                
            }


            items[Count] = item;
            Count++;
            
        }


        public void Remove(T itemToRemove)
        {
            bool itemIsFound = false;

            for (int i= 0; i <= Count; i++)
            {
                if (!itemIsFound)
                {
                    if (itemToRemove.Equals(items[i]) && itemIsFound == false)
                    {
                        items[i] = items[i + 1];
                        Count--;
                    }
                }
                else
                {
                    itemIsFound = default;

                }
            }



        }






        public void RemoveAt(int index)
        {
              if(index >= 0 && index < Count)
            {
                for (int i = index; i < Count; i++)
                {
                    if (i != Count - 1)
                    {
                        items[i] = items[i + 1];
                    }
                    else
                    {
                        items[i] = default(T);
                    }
                }
                Count--;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }



        public override string ToString()
        {
            string output = " ";

            if (Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    output += items[i].ToString() + "/ ";
                }

                output = output.Substring(0, output.Length - 2);
            }

            return output + " ";
        }

        public int Find(int v)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static object Zip(CustomListClass<int> testListOne, CustomListClass<int> testListTwo)
        {
            throw new NotImplementedException();
        }
    }


    //Overload + operator
    //You can use your Add method for this. The method signature you are looking for is:
    //public static CustomList<T> +(CustomList<T> listOne, CustomList<T> listTwo)



    public static CustomListClass<T> operator +(CustomListClass<T> list1, CustomListClass<T> list2)
    {
        CustomListClass<T> combinedList = new CustomListClass<T>();
        for (int i = 0; i < list1.Count; i++)
        {
            combinedList.Add(list1[i]);
        }
        for (int i = 0; i < list2.Count; i++)
        {
            combinedList.Add(list2[i]);
        }
        return combinedList;
    }

    public static CustomListClass<T> operator -(CustomListClass<T> list1, CustomListClass<T> list2)
    {
        CustomListClass<T> combinedList = new CustomListClass<T>();
        bool dataIsRepeated = false;
        foreach (T data in list1)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                if (data.Equals(list2[i]))
                {
                    dataIsRepeated = true;
                }
            }
            if (dataIsRepeated == false)
            {
                combinedList.Add(data);
            }
            dataIsRepeated = false;
        }
        foreach (T data in list2)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                if (data.Equals(list1[i]))
                {
                    dataIsRepeated = true;
                }
            }
            if (dataIsRepeated == false)
            {
                combinedList.Add(data);
            }
            dataIsRepeated = false;
        }
        return combinedList;
    }



    //Zip
    //Calls your Add method in a specific order (like a zipper) inside a loop

    public static CustomListClass<T> Zip(CustomListClass<T> list1, CustomListClass<T> list2)
    {
        CustomListClass<T> combinedList = new CustomListClass<T>();
        if (list1.Count >= list2.Count)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                combinedList.Add(list1[i]);
                if (i < list2.Count)
                {
                    combinedList.Add(list2[i]);
                }
            }
        }
        if (list1.Count < list2.Count)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                if (i < list1.Count)
                {
                    combinedList.Add(list1[i]);
                }
                combinedList.Add(list2[i]);
            }
        }
        return combinedList;
    }





    public class T
    {
    }
}

 

    

