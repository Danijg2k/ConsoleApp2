using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Extensions
{
    public static class ObjectExtension
    {
        // Prints out object to console
        public static Object Show(this Object obj, String methodDescription)
        {
            Console.WriteLine($"{methodDescription}\n\n{obj}\n===============");
            return obj;
        }
    }
}
