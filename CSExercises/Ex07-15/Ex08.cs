using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double  C, F;
            Console.Write("Please input the Centigrade temperature:");
            C = Convert.ToDouble(Console.ReadLine());
            F = Convert.ToDouble(1.8 * C + 32);
            Console.WriteLine("the Fahrenheit temperature is:" + F);

        }
    }
}
