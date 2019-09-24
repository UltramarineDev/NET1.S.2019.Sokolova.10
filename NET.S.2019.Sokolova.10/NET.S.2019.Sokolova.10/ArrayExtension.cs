using NET.S._2019.Sokolova._10.Interfaces;
using System;
using System.Collections.Generic;

namespace NET.S._2019.Sokolova._10
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Method filters array using condition
        /// </summary>
        /// <param name="source">input array</param>
        /// <param name="predicate">instance of IPredicate interface</param>
        /// <returns>array with numbers satisfying condition</returns>
        /// <exception cref="System.ArgumentException">Thrown when array is empty</exception>
        /// <exception cref="System.ArgumentNullException">Thrown when array is null</exception>
        public static TSource[] Filter<TSource>(this TSource[] source, IPredicate<TSource> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source array can not be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Source array can not be empty.", nameof(source));
            }

            List<TSource> resultList = new List<TSource>();
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate.IsPredicate(source[i]))
                {
                    resultList.Add(source[i]);
                }
            }

            return resultList.ToArray();
        }

        /// <summary>
        /// Method transform source array according to input condition
        /// </summary>
        /// <param name="source">array</param>
        /// <param name="transformer">parameter of type ITransformer</param>
        /// <returns>transformed array</returns>
        public static TResult[] Transform<TSource, TResult>(this TSource[] source, ITransformer<TSource, TResult> transformer)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source array can not be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Source array can not be empty.", nameof(source));
            }

            var resultArray = new TResult[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                resultArray[i] = transformer.TransformValue(source[i]);
            }

            return resultArray;
        }

        /// <summary>
        /// Method sorts array using condition
        /// </summary>
        /// <param name="source">input array</param>
        /// <param name="comparer">instance of IComparer</param>
        /// <returns>sorted array</returns>
        /// <exception cref="System.ArgumentException">Thrown when array is empty</exception>
        /// <exception cref="System.ArgumentNullException">Thrown when array is null</exception>
        public static TSource[] SortBy<TSource>(this TSource[] source, IComparer<TSource> comparer)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source array can not be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Source array can not be empty.", nameof(source));
            }

            bool swapped = true;
            while (swapped)
            {
                swapped = false;

                int i = 0;
                while (i < source.Length - 1)
                {
                    if (comparer.Compare(source[i], source[i + 1]) > 0)
                    {
                        TSource temp = source[i];
                        source[i] = source[i + 1];
                        source[i + 1] = temp;
                        swapped = true;
                    }

                    i++;
                }
            }

            return source;
        }

        //public IEnumerable<int> ConvertToNumbers(string[] inputArray, int p)
        //{

        //}
    }
}
