using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            double output;
            int i;
            for (i = 1; i <= 25; i++) 
           {
               output  = SQT (i);
               Console.WriteLine(i + ":{0:0.00000}" ,output);
           }
        }

        public static double SQT(int y)
        {
            Random r = new Random();
            double G = r.Next(1, y);
            do
            {
                G = (G + y / G) / 2.0;
            } while (Math.Abs(y - G * G) > 0.00001);
            return G;
            //double G = Math.Sqrt(y);
            //return G;
        }
    }
}
