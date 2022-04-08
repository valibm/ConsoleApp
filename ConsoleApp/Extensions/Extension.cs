using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Extensions
{
    internal static class Extension
    {
        public static T[] CustomResize<T>(this T[] array, int newLength)
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
    }
}
