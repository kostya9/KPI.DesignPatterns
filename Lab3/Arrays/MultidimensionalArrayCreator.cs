using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.Arrays
{
    public class MultidimensionalArrayCreator
    {
        public static MultidimensionalArray FromDimensions(int dimensions)
        {
            return new MultidimensionalArray(CreateArrayFromDimensions(dimensions));
        }

        private static Array CreateArrayFromDimensions(int dimensions)
        {
            var lengths = new int[dimensions].Select(i => MultidimensionalArray.Length).ToArray();
            return Array.CreateInstance(typeof(int), lengths);
        }
    }
}
