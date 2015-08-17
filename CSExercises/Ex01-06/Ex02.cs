using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int a,b;
            Console.Write("Please input a number:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Math.Pow(a,2));
            Console.WriteLine(b);
        }
    }
}
