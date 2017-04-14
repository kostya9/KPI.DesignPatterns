using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.Arrays
{
    public class MultidimensionalArray
    {

        public static readonly int Length = 3;
        private readonly Array _array;

        public MultidimensionalArray(Array array)
        {
            _array = array;
        }

        public int GetValue(int[] indeces)
        {
            return (int)_array.GetValue(indeces);
        }

        public void SetValue(int value, int[] indeces)
        {
            _array.SetValue(value, indeces);
        }

        private static Array CreateArrayFromDimensions(int dimensions)
        {
            var lengths = new int[dimensions].Select(i => Length).ToArray();
            return Array.CreateInstance(typeof(int), lengths);
        }

        public void InitializeWithRandom()
        {
            var random = new Random();
            int max = 1000;
            for (int i = 0; i < _array.Length; i++)
            {
                var indices = GetMultidimensionalIndexFromFlattened(i);
                var value = random.Next(max);
                _array.SetValue(value, indices);
            }
        }

        public static MultidimensionalArray FromDimensions(int dimensions)
        {
            return new MultidimensionalArray(CreateArrayFromDimensions(dimensions));
        }

        private int[] GetMultidimensionalIndexFromFlattened(int i)
        {
            var indices = new int[_array.Rank];
            for (int j = _array.Rank - 1; j >= 0; j--)
            {
                indices.SetValue(i % Length, j);
                i /= Length;
            }

            return indices;
        }

        public void Sort()
        {
            var oneDimensionalSorted = Flatten();
            Array.Sort(oneDimensionalSorted);

            
            for (int i = 0; i < oneDimensionalSorted.Length; i++)
            {
                var indices = GetMultidimensionalIndexFromFlattened(i);
                _array.SetValue(oneDimensionalSorted.GetValue(i), indices);
            }
        }

        public void Inverse()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                var indices = GetMultidimensionalIndexFromFlattened(i);
                _array.SetValue(- (int)_array.GetValue(indices), indices);
            }
        }

        public Array Flatten()
        {
            return _array.Cast<int>().ToArray();
        }
    }
}
