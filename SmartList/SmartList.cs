using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Implementation.SmartList
{
    internal class SmartList<T>
    {
        private T[] _data;
        private int _capacity;
        private int _count;

        public int Capacity { get => _capacity; private set => _capacity = value; }
        public int Count { get => _count; private set => _count = value; }

        public SmartList()
        {
            this._data = new T[4];
            this.Capacity = 4;
            this.Count = 0;
        }

        public SmartList(int capacity)
        {
            this.Capacity = capacity;
            this._data = new T[capacity];
            this.Count = 0;
        }

        public T this[int index]
        {
            get 
            { 
                if (checkIndex(index))
                {
                    return _data[index];
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
                    _data[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                extend();
            }
            _data[Count++] = item;
        }

        private void extend()
        {
            Capacity = Capacity * 2;
            T[] _temp = new T[Capacity];
            for (int i = 0; i < Count; i++)
                _temp[i] = _data[i];
            _data = _temp;
        }

        private bool checkIndex(int idx)
        {
            if (idx >= Count || idx < 0)
            {
                return false;
            }
            return true;
        }

    }
}
