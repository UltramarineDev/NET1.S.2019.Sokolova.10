namespace NET.S._2019.Sokolova._10.Interfaces
{
    public interface IPredicate<TSource>
    {
        /// <summary>
        /// Condition method
        /// </summary>
        /// <param name="value">input value</param>
        /// <returns>true if condition is correct, false otherwise</returns>
        bool IsPredicate(TSource value);
    }
}
