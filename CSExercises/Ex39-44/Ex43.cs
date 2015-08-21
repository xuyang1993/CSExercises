using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            string output=null ;
            string [] sixteen=new string []
                {"0","1","2","3","4","5","6","7",
                "8","9","A","B","C","D","E","F"};
            int m = 0,j = i ;
            do
            {
                i = i / 16;
                j = j % 16;
                if (j < 11)
                {
                    output = output.Insert (0,Convert.ToString(j));
                }
                else
                {
                    output = output.Insert (0,sixteen[j]);
                }
                m = m + 1;
            } while (i >= 16);
            return output;
        }
    }
}
