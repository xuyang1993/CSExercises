using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Substring(i, s2.Length) == s2)
                    return true;
            }
                return false;
        }
    }
}
