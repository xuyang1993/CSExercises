using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            //a.
            //Console.Write("please enter a phrase:");
            //string phrase = Convert.ToString(Console.ReadLine());
            //string [] vowels = new string[] { "a", "e", "i", "o", "u" };
            //int count = 0;
            //for (int i = 0; i < phrase.Length; i++) 
            //{
            //    for (int j = 0; j < vowels.Length; j++) 
            //    {
            //        string r = phrase.Substring(i, 1);
            //        if (r == vowels[j]) 
            //        {
            //            count = count + 1;
            //        }
            //    }
            //}
            //Console.WriteLine("Total number of vowels:" + count);

            //b.
            Console.Write("please enter a phrase:");
            string phrase = Convert.ToString(Console.ReadLine());
            string[] vowels = new string[] { "a", "e", "i", "o", "u" };
            int [] number=new int[]{0,0,0,0,0};
            for (int i = 0; i < phrase.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    string r = phrase.Substring(i, 1);
                    if (r == vowels[j])
                    {
                        number[j] = number[j] + 1;
                    }
                }
            }
            for (int k = 0; k < vowels.Length; k++) 
            {
                Console.WriteLine("number of {0}: {1}", k, number[k]);
            }
        }
    }
}
