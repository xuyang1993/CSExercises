using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            //int x, y;
            //Console.WriteLine("X            Y");
            //Console.WriteLine("------------------");
            //for (x = -5; x <= 5; x ++ )
            //{
            //    y = 2 * x * x - 4 * x + 3;
            //    Console.WriteLine("{0:0.0}         {1:0.0}", x, y); 
            //}

            int x, y, i ;
            for (x = -20; x <= 20; x++) 
            {
                y = 2 * x * x - 4 * x + 3;
                i = 0;
                do
                {
                    Console.Write("*");
                    i = i + 1;
                } while (i != y);
                Console.WriteLine(y);
            }
        }
    }
}
