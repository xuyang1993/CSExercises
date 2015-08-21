using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] index = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                int randomnumber = r.Next(0, 10);
                for (int j = 0; j < 10; j++)
                {
                    if (randomnumber ==index [j ])
                        count[j] = count[j] + 1;
                }
            }
            //Number & Count
            Console.WriteLine("Number\tCount");
            for (int m = 0; m < 10; m++)
                Console.WriteLine("  "+index[m] + "\t  " + count[m]);
            //Number & *
            string[] star = new string[10];
            for (int n = 0; n < 10; n++)
            {
                for (int k = 0; k < count[n]; k++)
                {
                    star[n] = star[n] + "*";
                    //Console .Write ("*");
                }
            }
            Console.WriteLine("Number");
            for (int m = 0; m < 10; m++)
                Console.WriteLine("  " + index[m] + "  " + star[m]);
        }
    }
}
