using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double  i = 1;
            Console .WriteLine ("NO      INVERSE    SQUARE ROOT   SQUARE");
            Console .WriteLine ("-----------------------------------------");
            for (i = 1; i <=10 ; i ++)
            {
                Console.WriteLine("{0:0.0}     {1::0.000}     {2::0.000}        {3::0.0}", i, 1 / i, Math.Sqrt(i), i * i);
            }
        }
    }
}
