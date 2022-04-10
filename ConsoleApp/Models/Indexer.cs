using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
        /// <summary>
        /// Changes the length of array to a specified newLength
        /// </summary>
        /// <param name="array">Array that needs it's length changed</param>
        /// <param name="newLength">New length of the array</param>
        /// <returns></returns>
        public static T[] CustomResize( T[] array, int newLength)
        {
            int loopCount = newLength > array.Length ? array.Length : newLength;
            T[] newArray = new T[newLength];
            for (int i = 0; i < loopCount; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        /// <summary>
        /// Prints Elements of the array
        /// </summary>
        public void PrintElements()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item.ToString());
            }
        }
        /// <summary>
        /// Prints specified element of the array
        /// </summary>
        /// <param name="index">Index of printed element</param>
        public void PrintElements(int index)
        {
            Console.WriteLine(_array[index].ToString());
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
