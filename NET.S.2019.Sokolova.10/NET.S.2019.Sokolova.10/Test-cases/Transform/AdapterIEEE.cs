using NET.S._2019.Sokolova._10.Interfaces;

namespace NET.S._2019.Sokolova._10.Test_cases.Transform
{
    /// <summary>
    /// Class implements interface ITransformer
    /// </summary>
    public class AdapterIEEE<TSource, TResult> : ITransformer<double,string>
    {
        /// <summary>
        /// Transform double using external extension method 
        /// </summary>
        /// <param name="number">input number</param>
        /// <returns>string - result of transformation</returns>
        public string TransformValue(double number)
        {
            return number.GetIEEEBinaryString();
        }
    }
}
