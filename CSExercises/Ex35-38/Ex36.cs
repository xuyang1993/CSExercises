using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            //a.
            //Console.Write("input a word/phrase:");
            //string word = Convert.ToString(Console.ReadLine());
            //int i;
            //for (i = 0; i <= word.Length / 2; i++)
            //{
            //    string r=word.Substring (i,1);
            //    string s=word.Substring(word .Length-1-i ,1);
            //    if (r != s)
            //    {
            //        Console.WriteLine("not Palindrome");
            //        break;
            //    }
            //}
            //if (i > word.Length / 2)
            //    Console.WriteLine("Palindrome");

            //b.
            Console.Write("input a sentence:");
            string word = Convert.ToString(Console.ReadLine());

            //ToLower
            for (int x = 0; x < word.Length; x++)
                word = word.ToLower();

            //Split
            string[] split = word.Split(' ');
            //int m;
            ////Console.WriteLine("word length - " + word.Length);
            //for (m = 0; m < split.Length; m++)
            //{
            //    //Console.WriteLine(split[m]);
            //    Console.Write("");
            //}
            ////Console.WriteLine("m - " + m);

            //Trim(chars)
            char[] c = new char[] { '.', ',', '!', '?' };
            int n;
            string[] trimchar = new string[split.Length];
            for (n = 0; n < split.Length; n++)
            {
                trimchar[n] = split[n].Trim(c);
                //Console.WriteLine(trimchar[n]);
            }

            //one line
            string b = "";
            for (int k = 0; k < trimchar.Length; k++)
            {
                string WORD=trimchar [k];
                if (WORD .Length >=1)
                {
                    //Console.WriteLine(WORD.Length);
                    WORD = WORD.Substring(0, WORD.Length);
                    b = b + WORD;
                }
            }
            //Console.WriteLine(b);

            //judge
            int i;
            for (i = 0; i <= b.Length / 2; i++)
            {
                string r = b.Substring(i, 1);
                string s = b.Substring(b.Length - 1 - i, 1);
                if (r != s)
                {
                    Console.WriteLine("not Palindrome");
                    break;
                }
            }
            if (i > b.Length / 2)
                Console.WriteLine("Palindrome");
        }
    }
}
