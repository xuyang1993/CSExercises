using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string output=null;
            int len = s.Length;
            for (int i = 0; i < len ; i++)
            {
                char find=Convert.ToChar (s.Substring(i ,0));
                if (find == c1)
                {
                    output = s.Insert(i, Convert.ToString(c2));
                    len=len+1;
                }
            }
            output = output.Trim(c1);
            return output;
        }
    }
}
