using System;
using System.Collections.Generic;

namespace IntegerConverter
{
    public static class CustomConverter
    {
        public static int[] ConvertToInt(string[] inputSet, int p)
        {
            if (inputSet == null)
            {
                throw new ArgumentNullException("Input array is null!", nameof(inputSet));
            }

            if (inputSet.Length == 0)
            {
                throw new ArgumentException("Input array is empty!", nameof(inputSet));
            }

            if(p < 2 || p > 16)
            {
                throw new ArgumentException("Invalid numeral system!", nameof(p));
            }

            List<int> resultSet = new List<int>();
            foreach (var member in inputSet)
            {
                resultSet.Add(CastToDecimal(member, p));
            }

            return resultSet.ToArray();
        }

        private static int CastToDecimal(string member, int p)
        {
            Dictionary<char, int> dictionary = GetDictionary();
            int result = 0;
            for (int i = 0; i < member.Length; i++)
            {
                int temp = (int)char.GetNumericValue(member[i]);

                if (temp >= p)
                {
                    throw new ArgumentException("Invalid input number!", nameof(member));
                }

                if (temp == -1)
                {
                    if (dictionary[member[i]] >= p)
                    {
                        throw new ArgumentException("Invalid input number!", nameof(member));
                    }

                    temp = dictionary[member[i]];
                }

                result += (int)(temp * Math.Pow(p, member.Length - i - 1));
            }

            return result;
        }

        private static Dictionary<char, int> GetDictionary()
        => new Dictionary<char, int>
        {
            ['A'] = 10,
            ['B'] = 11,
            ['C'] = 12,
            ['D'] = 13,
            ['E'] = 14,
            ['F'] = 15
        };
    }
}
