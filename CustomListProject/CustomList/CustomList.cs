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
                T[] temp = new T[capacity * 2];
                for(int i =0; i < capacity; i++)
                {
                    temp[i] = items[i];
                    capacity *= 2;
                    items = temp;
                }

                // fill up new bigger array with old stuff
                // update 'items' to be the new, bigger array
            }


            items[count] = item;
            count++;
            
        }

    }

    
}
    

