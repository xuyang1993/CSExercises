using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input an integer");
            int N = Convert.ToInt32(Console.ReadLine());
            int i ,j = 0;
            for (i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    j = i + j;
                }
            }
            if (j == N)
                Console.WriteLine("perfect number");
            else
                Console.WriteLine("not perfect number");
        }
    }
}
