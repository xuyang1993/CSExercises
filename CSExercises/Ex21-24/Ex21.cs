using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            //int number = -1 ;
            //while (number != 88)
            //{
            //    Console.WriteLine("please enter an integer number:");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    if (number == 88)
            //    {
            //        Console.WriteLine("Lucky you...");
            //    }
            //}

            
            int number;
            do
            {
                Console.WriteLine("please enter an integer number:");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number != 88);
            Console.WriteLine("Lucky you...");
        }
    }
}
