using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            double distance, tfare;
            Console.Write("reads the distance:");
            distance = Convert.ToDouble(Console.ReadLine());
            tfare = Convert.ToDouble(2.40 + distance * 0.4);
            Console.WriteLine("the total fare is:" + tfare);
            tfare = Math.Round(tfare, 1);
            Console.WriteLine("the printed fare is:" + tfare);
        }
    }
}
