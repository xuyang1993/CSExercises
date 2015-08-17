using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            double x, y;
            Console.Write("Please input the value of x:");
            x = Convert.ToDouble(Console .ReadLine ());
            y = Convert.ToDouble(2 * Math.Pow(x, 2) - 4 * x + 3);
            Console.WriteLine(y);
        }
    }
}
