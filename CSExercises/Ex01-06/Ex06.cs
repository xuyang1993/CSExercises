using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int a;
            double b;
            Console.Write("Please input a number:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToDouble(Math.Sqrt(a));
            Console.WriteLine(b);     
          
        }
    }
}
