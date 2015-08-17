using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("please input a three-digit interger:");
            d = Convert.ToInt32(Console.ReadLine());
            if (d > 99 && d < 1000)
            {
                a = d / 100;
                b = (d % 100) / 10;
                c = d % 10;
                if (d == a * a * a + b * b * b + c * c * c)
                    Console.WriteLine("this interger is an armstrong number.");
                else
                    Console.WriteLine("this inerger is not an armstrong number.");
            }
            else
                Console.WriteLine("it's an invalid interger");
        }
    }
}