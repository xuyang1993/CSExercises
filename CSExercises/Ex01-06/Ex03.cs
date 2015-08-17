using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double a, b;
            Console.Write("Please input a number:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Math.Pow(a, 2));
            Console.WriteLine(b);   
        }
    }
}
