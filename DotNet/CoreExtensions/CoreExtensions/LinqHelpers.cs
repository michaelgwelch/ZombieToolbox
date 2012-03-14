using System;
using System.Collections.Generic;

namespace ZombieToolbox.System
{
    /// <summary>
    /// Extension methods which help to make linq more useful
    /// </summary>
    public static class LinqHelpers
    {
        /// <summary>
        /// Converts a single value to an enumeration. (null values are
        /// converted to empty enumerations)
        /// </summary>
        /// <param name='val'>
        /// The value to be converted
        /// </param>
        /// <typeparam name='T'>
        /// The type of the value
        /// </typeparam>
        public static IEnumerable<T> Enumerable<T>(this T val)
        {
            if(val != null)
            {
                yield return val;
            }
        }
    }
}

