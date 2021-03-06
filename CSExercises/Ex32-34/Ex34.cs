using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] marks = new int[12, 4] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, 
            { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, 
            { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };

            //a.
            int[] tmarks = new int[12];
            for (int i = 0; i < 12; i++)
            {
                tmarks[i] = marks[i, 0] + marks[i,1] + marks[i, 2] + marks[i, 3];
                Console.WriteLine("student {0} total marks are:{1}", i + 1, tmarks[i]);
            }

            //b.
            double [] amarks = new double [4];
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 12; k++)
                {
                    amarks[j] = amarks[j] + marks[k, j];
                }
                Console.WriteLine("the average marks for subject {0} are {1:0.00}", j + 1, amarks[j] / 12);
            }

            double[] z = new double [12];
            double n = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    z[y] = marks[y, x] - amarks[x] / 12;
                    n = n + z[y] * z[y];
                }
                double VARIANCE = n / 12;
                double standeviation = Math.Sqrt(VARIANCE);
                Console.WriteLine("the standard deviation of marks for subject {0} are {1:0.000}", x + 1, standeviation );
            }

            //c.
            double oamarks = 0;
            for (int m = 0; m < 4; m++)
            {
                oamarks = oamarks + amarks[m];
            }
            Console.WriteLine("the overall average of marks are " + oamarks/12);
        }
    }
}
