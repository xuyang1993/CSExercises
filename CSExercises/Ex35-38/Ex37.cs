using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input your sentence:");
            string sentence = Convert.ToString(Console.ReadLine());

            //Split
            string [] split = sentence.Split (' ');
            int m;
            for (m = 0; m < split.Length; m++)
            {
                Console.Write("");
                //Console.WriteLine(split[m]);
            }

            //ToUpper
            string b = "";
            for (int i = 0; i < split .Length ; i++)
            {
                string word = split[i];
                if (word.Length >= 1)
                {
                    word = word.ToUpper().Substring(0, 1) + word.Substring(1, word.Length-1);
                    b = b + word + " ";
                }
            }
            Console.WriteLine(b);
        }
    }
}
