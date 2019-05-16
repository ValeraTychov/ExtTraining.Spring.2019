using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class Generator
    {
        public static IEnumerable<T> Generate<T>(T a, T b, Func<T, T, T> function)
        {
            T current = b;
            T previous = a;

            yield return a;
            yield return b;

            while (true)
            {
                T next = function(a, b);
                a = b;
                b = next;
                yield return next;
            }
        }
    }
}
