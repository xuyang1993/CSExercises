using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int N, i, j;
            for (N = 2; N < 1000; N++)
            {
                j = 0;
                for (i = 1; i < N ; i++)
                {
                    if (N % i == 0)
                        j = i + j;
                }
                if (j == N)
                    Console.WriteLine(N);
            }
        }
    }
}
