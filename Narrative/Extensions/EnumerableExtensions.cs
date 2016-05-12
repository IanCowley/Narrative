using System;
using System.Collections.Generic;

namespace Narrative.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T, int> action)
        {
            var i = 0;

            foreach (T item in sequence)
            {
                action(item, i);
                i++;
            }
        }
    }
}
