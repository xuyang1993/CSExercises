using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input your grades:");
            int grades = Convert.ToInt32(Console.ReadLine());
            if (grades >=0 && grades <=100)
            {
                if (grades >= 80 && grades <= 100)
                    Console.WriteLine("You scored {0} marks which is A grade", grades);
                else if (grades >= 60 && grades <=79)
                    Console.WriteLine("You scored {0} marks which is B grade", grades);
                else if (grades >= 40 && grades <=59)
                    Console.WriteLine("You scored {0} marks which is C grade", grades);
                else
                    Console.WriteLine("You scored {0} marks which is F grade", grades);
            }
            else
                Console.WriteLine("**Error**");
        }
    }
}