using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Implementation.SmartList
{
    internal class SmartList<T>
    {
        private T[] _data;
        private int _count;

        public int Capacity => _data.Length;
        public int Count => _count;

        public SmartList()
        {
            _data = new T[4];
            _count = 0;
        }

        public SmartList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new Exception("Capacity Can't be zero or negative.");
            }

            _data = new T[capacity];
            _count = 0;
        }

        public T this[int index]
        {
            get 
            {
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                
                return _data[index];
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                
                _data[index] = value;
            }
        }

        public void Add(T item)
        {
            if (_count == Capacity)
            {
                extend();
            }
            _data[_count++] = item;
        }

        private void extend()
        {
            int newCapacity = Capacity == 0? 4 : Capacity * 2;
            T[] _temp = new T[Capacity];

            Array.Copy(_data, _temp, _count);
            
            _data = _temp;
        }

    }
}
