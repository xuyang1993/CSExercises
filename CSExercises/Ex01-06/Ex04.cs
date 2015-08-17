using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Double a, b;
            Console.Write("Please input a number:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Math.Sqrt(a));
            Console.WriteLine(b);     
        }
    }
}
