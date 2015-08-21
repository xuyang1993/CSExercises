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
            Console.Write("input your sentence:");
            string sentence = Convert.ToString(Console.ReadLine());

            //Split
            string [] split = sentence.Split (new char []{' '});
            
            //ToUpper
            string b = "";
            for (int i = 0; i < split .Length ; i++)
            {
                //Console.WriteLine(split[i]);
                string word = split[i];
                if (word.Length > 0)
                {
                    word = word.ToUpper().Substring(0, 1) + word.Substring(1, word.Length - 1);
                    b = b + word+" ";
                }
            }
            Console.WriteLine(b);
        }
    }
}
