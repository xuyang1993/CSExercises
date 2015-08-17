using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s,area;
            Console.Write("please input the length of sides a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("please input the length of sides b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("please input the length of sides c:");
            c = Convert.ToDouble(Console.ReadLine());
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("the area of the triangle is:" + area);
        }
    }
}