using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Implementation.SmartList
{
    internal class SmartList<T>
    {
        private T[] data;
        private int capacity;
        private int count;

        public int Count => count;
        public int Capacity => capacity;
        public SmartList()
        {
            this.data = new T[4];
            this.capacity = 4;
            this.count = 0;
        }

        public SmartList(int capacity)
        {
            this.capacity = capacity;
            this.data = new T[capacity];
            this.count = 0;
        }

        public T this[int index]
        {
            get 
            { 
                if (checkIndex(index))
                {
                    return data[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
            set
            {
                if (checkIndex(index))
                {
                    data[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }

        private bool checkIndex(int idx)
        {
            if (idx > Count || idx < 0)
            {
                return false;
            }
            return true;
        }

    }
}
