using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class List<T> : IEnumerable<T>
    {
        private T[] data;

        private int count;

        private int enumeratorsCount;

        public List(int capacity)
        {
            if (capacity < 0) throw new ArgumentException("Capacity should be zero or positive.");

            data = new T[capacity];
            count = 0;
        }

        public List() : this(capacity: 12)
        {

        }

        public int Count
        {
            get {
                return count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new ArgumentOutOfRangeException();

                return data[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new ArgumentOutOfRangeException();

                data[index] = value;
            }
        }

        public void Add(T item)
        {
            if (enumeratorsCount > 0)
                throw new InvalidOperationException(
                    "Collection cannot be modified untill all enumerators will be disposed."
                );

            if (data.Length == count)
            {
                Extend();
            }

            data[count] = item;
            count++;
        }

        private void Extend()
        {
            var newData = new T[data.Length * 2];
            Array.Copy(data, newData, data.Length);
            data = newData;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var result = new Enumerator(this);
            enumeratorsCount++;
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class Enumerator : IEnumerator<T>
        {
            private readonly List<T> list;
            private int index = -1;

            public Enumerator(List<T> list)
            {
                this.list = list;
            }

            public T Current
            {
                get
                {
                    return list[index];
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                list.enumeratorsCount--;
            }

            public bool MoveNext()
            {
                if (index < (list.count - 1))
                {
                    index++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }
    }
}
