using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string name, gender;
            int age;
            Console.WriteLine("please input your name:");
            name = Console.ReadLine();
            Console.WriteLine("please input your gender(M/F):");
            gender = Console.ReadLine();
            Console.WriteLine ("please input your age:");
            age=Convert .ToInt32 (Console .ReadLine ());
            if (gender == "M")
            {
                if (age >=40 )
                    Console.WriteLine("Good Morning Uncle " + name);
                else 
                    Console.WriteLine("Good Morning Mr." + name);
            }
            else if (gender == "F")
            {
                if (age >= 40)
                    Console.WriteLine("Good Morning Aunty " + name);
                else
                    Console.WriteLine("Good Morning Ms." + name);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}