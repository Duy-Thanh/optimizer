using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer
{
    /// <summary>
    /// Extension methods on sequence of <see cref="ByteSize"/> values.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Computes the sum of a sequence of <see cref="ByteSize"/> values.
        /// </summary>
        /// <param name="byteSizes">A sequence of <see cref="ByteSize"/> values to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static ByteSize Sum(this IEnumerable<ByteSize> byteSizes)
        {
            return byteSizes.Aggregate((current, byteSize) => current + byteSize);
        }
    }
}
