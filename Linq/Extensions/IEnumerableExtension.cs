using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Extensions
{
    public static class IEnumerableExtension
    {
        // List also implement IEnumerable (can use method)
        public static IEnumerable<T> Show<T>(this IEnumerable<T> enumerator, String methodDescription)
        {
            Console.WriteLine(methodDescription + "\n");
            foreach (var item in enumerator)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===============");
            return enumerator;
        }
    }
}
