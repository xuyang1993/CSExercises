using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] ORDER = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i, j, temp;
            for (i = 0; i < ORDER.Length-1; i++)
            {
                for (j = i + 1; j < ORDER.Length; j++) 
                {
                    if (ORDER[j] > ORDER[i])
                    {
                        temp = ORDER[j];
                        ORDER[j] = ORDER[i];
                        ORDER[i] = temp;
                    }
                }
                for (int k = 0; k < ORDER.Length; k++)
                Console.Write("{0} ", ORDER[k]);
                Console.WriteLine("");
            }
            //for (int k = 0; k < ORDER.Length; k++)
            //{
            //    Console.Write("{0} ", ORDER[k]);
            //}
        }
    }
}
