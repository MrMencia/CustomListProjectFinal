using System;
namespace CustomList
{
    public class CustomListClass<T>
    {

        private T[] items;
        private int count;
        private int capacity;

        // property for Capacity

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }


        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }



        public CustomListClass()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;

        }



        public void Add(T item)
        {
            if(count == capacity)
            {
                capacity *= 2;

                T[] temp = new T[capacity];
                for(int i =0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
                
            }


            items[count] = item;
            count++;
            
        }


        public void Remove(T itemToRemove)
        {
            bool itemIsFound = false;

            for (int i= 0; i <= count; i++)
            {
                if (!itemIsFound)
                {
                    if (itemToRemove.Equals(items[i]) && itemIsFound == false)
                    {
                        items[i] = items[i + 1];
                        count--;
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
              if(index >= 0 && index < count)
            {
                for (int i = index; i < count; i++)
                {
                    if (i != count - 1)
                    {
                        items[i] = items[i + 1];
                    }
                    else
                    {
                        items[i] = default(T);
                    }
                }
                count--;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int Find(int v)
        {
            throw new NotImplementedException();
        }
    }

    
}
    

