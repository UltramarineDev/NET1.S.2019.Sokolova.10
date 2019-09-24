using NET.S._2019.Sokolova._10.Interfaces;

namespace NET.S._2019.Sokolova._10.Test_cases.Filter
{
    /// <summary>
    /// Class EvenOrOdd with implementation of IPredicate interface
    /// </summary>
    public class EvenOrOdd<TSource> : IPredicate<int>
    {
        /// <summary>
        /// Method determines if number is even or odd
        /// </summary>
        /// <param name="value">input number</param>
        /// <returns>true if number is even and false - if odd</returns>
        public bool IsPredicate(int value)
        {
            return value % 2 == 0;
        }
    }
}
