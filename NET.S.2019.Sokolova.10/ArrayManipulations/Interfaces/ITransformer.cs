﻿namespace ArrayManipulations.Interfaces
{
    /// <summary>
    /// Interface represents method TransformValue
    /// </summary>
    public interface ITransformer<TSource, TResult>
    {
        /// <summary>
        /// Transforms the given value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>result of tranformation</returns>
        TResult TransformValue(TSource value);
    }
}
