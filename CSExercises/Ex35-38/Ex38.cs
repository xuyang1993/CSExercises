using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[] { 63, 29, 75, 82, 55 };

            //a.
            int i , j , temp ;
            string TEMP,s="Name",r="Mark";
            Console.WriteLine(s.PadRight(10, ' ') + r+"\n");
            for (i = 0; i < mark.Length; i++)
            {
                for (j = i + 1; j < mark.Length; j++)
                {
                    if (mark[i ]<mark [j ])
                    {
                        temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;

                        TEMP = name[i];
                        name[i] = name[j];
                        name[j] = TEMP;
                    }
                }
                Console .WriteLine (name[i ].PadRight (10,' ')+mark [i ]);
            }

            //b.
            int alpha;
            string ALPHA, S = "Name", R = "Mark";
            Console.WriteLine("\n\n"+S.PadRight(10, ' ') + R+"\n");
            for (i = 0; i < mark.Length; i++)
            {
                for (j = i + 1; j < mark.Length; j++)
                {
                    string M = name[i], N = name[j];
                    if (M.CompareTo(N)>0)
                    {
                        alpha  = mark[i];
                        mark[i] = mark[j];
                        mark[j] = alpha ;

                        ALPHA  = name[i];
                        name[i] = name[j];
                        name[j] = ALPHA ;
                    }
                }
                Console.WriteLine(name[i].PadRight(10, ' ') + mark[i]);
            }
        }
    }
}
