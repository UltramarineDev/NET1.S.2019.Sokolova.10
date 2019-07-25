using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Sokolova._10
{
    public static class ArrayExtension
    {
        public static TSource[] SortBy<TSource>(this TSource[] source, IComparer<TSource> comparer)
        {
            List<TSource> listResult = new List<TSource>();
            
            foreach(var item in source)
            {
                listResult.Add(item);
            }

            for (int i = 0; i < listResult.Count; i++)
            {
                for (int j = 0; j < listResult.Count - i - 1; j++)
                {
                    if (comparer.Compare(listResult[j], listResult[j + 1]) > 0)
                    {
                        TSource temp = listResult[j];
                        listResult[j] = listResult[j + 1];
                        listResult[j + 1] = temp;
                    }
                }
            }

            return listResult.ToArray();
        }

        public static TSource[] Filter<TSource>(this TSource[] source, IPredicate<TSource> predicate)
        {
            List<TSource> resultList = new List<TSource>();

            for(int i = 0; i < source.Length; i++)
            {
                //if(predicate.IsPredicate(source[i]))
                //{
                //    resultList.Add(source[i]);
                //}
            }

            return resultList.ToArray();
        }

        //public IEnumerable<int> ConvertToNumbers(string[] inputArray, int p)
        //{

        //}
    }
}
