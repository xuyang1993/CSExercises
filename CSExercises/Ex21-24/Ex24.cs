using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter an inertger N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            double G = r.Next(1, N);
            Console.WriteLine(G);
            if (N ==G *G )
            {
                Console.WriteLine("Guess is correct");
            }
            else
            {
                do
                {
                    G = (G + N / G) / 2;
                } while (N != G * G);
                Console.WriteLine("{0:0.00000}", G);
            }
        }
    }
}
