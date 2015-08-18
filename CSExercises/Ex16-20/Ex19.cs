using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input your travel distance(km):");
            double distance=Convert .ToDouble (Console .ReadLine ());
            distance = Math.Ceiling(distance * 10);
            if (distance <= 0.5)
            {
                Console .WriteLine ("charge:$2.40");
            }
            else if (distance > 0.5 && distance <= 9)
            {
                Console .WriteLine ("charge:${0:0.00}",(distance -5)*0.04);
            }
            else
            {
                Console .WriteLine ("charge:${0:0.00}",2.40+85*0.04+(distance -90)*0.05);
            }
        }
    }
}