using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("please enter number A :");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number B :");
            B = Convert.ToInt32(Console.ReadLine());
            C = A * B;
            do
            {
                if (A > B)
                    A = A - B;
                else
                    B = B - A;
            } while (A != B);
            Console.WriteLine("HCF:" + A);
            Console.WriteLine("LCM:" + C / A);

        }
    }
}
