using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer number:");
            int N = Convert.ToInt32(Console.ReadLine());
            int x;
            for  (x = 2; x < N ; x ++)
            {
                if (N % x == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }
            Console.WriteLine("Prime");
        }
    }
}
