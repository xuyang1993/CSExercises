using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            long factorial = 1;
            for (int i = 0; i < n;i ++ )
            {
                factorial = factorial * i;
            }
            return factorial ;
        }
    }
}
