using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int i, j;
            for (i = 5; i < 10000; i++)
            {
                double m = Math.Sqrt(i);
                for (j = 2; j <= m; j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (j >m )
                    Console.Write("\t"+i);
            }
        }
    }
}
