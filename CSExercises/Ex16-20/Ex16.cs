using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string name, gender;
            Console.WriteLine("please input your name:");
            name = Console.ReadLine();
            Console.WriteLine("please input your gender(M/F):");
            gender = Console.ReadLine();

            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr." + name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms." + name);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}