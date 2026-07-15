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
        }

    }
}
