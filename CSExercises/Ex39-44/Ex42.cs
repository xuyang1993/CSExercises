using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Substring(i, s2.Length) == s2)
                    return i ;
            }
            return -1;
        }
    }
}
