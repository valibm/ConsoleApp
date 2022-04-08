using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Extensions;

namespace ConsoleApp.Models
{
    internal class Indexer<T> :IEnumerable
    {
        private static T[] _array;
        public T this[int index]
        {
            get
            {
                if (index < _array.Length && index >= 0)
                {
                    return _array[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _array.Length && index >= 0)
                {
                    _array[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public int Length { get { return _array.Length; } }
        public Indexer() : this(0) { }
        public Indexer(int index)
        {
            _array = new T[index];
        }
        public void Add(T input)
        {
            T[] newArray = CustomResize(_array, _array.Length + 1);
            newArray[^1] = input;
            _array = newArray;
        }
        public static T[] CustomResize( T[] array, int newLength)
        {
            int loopCount = 0;
            loopCount = newLength > array.Length ? array.Length : newLength;
            T[] newArray = new T[newLength];
            for (int i = 0; i < loopCount; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                yield return _array[i];
            }
        }

    }
}
