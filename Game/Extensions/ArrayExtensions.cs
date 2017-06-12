using System;

namespace Bare
{
    static class ArrayExtensions
    {
        /// <summary>
        /// Create a subset of an array gicen a start and length.
        /// </summary>
        /// <returns>The subset of an array.</returns>
        /// <param name="startIndex">The starting index from which to copy.</param>
        /// <param name="length">The number of elements to copy.</param>
        public static T[] RangeSubset<T>(this T[] array, int startIndex, int length)
        {
            T[] subset = new T[length];
            Array.Copy(array, startIndex, subset, 0, length);
            return subset;
        }

        /// <summary>
        /// Create a subset of an array given a list of indices.
        /// </summary>
        /// <returns>The subset of an array.</returns>
        /// <param name="indices">Indices from which to copy.</param>
        public static T[] Subset<T>(this T[] array, params int[] indices)
        {
            T[] subset = new T[indices.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                subset[i] = array[indices[i]];
            }
            return subset;
        }
    }
}
