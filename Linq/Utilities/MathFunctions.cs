using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Utilities
{
    public class MathFunctions
    {
        // Checks if number is prime or not
        public bool IsPrime(int num)
        {
            if (num == 1) return false;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
