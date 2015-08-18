using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("enter quantity for TV:");
            int TV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter quantity for DVD:");
            int DVD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter quantity for MP3:");
            int MP3 = Convert.ToInt32(Console.ReadLine());
            amount=900*TV+500*DVD+700*MP3;
            if (amount <5000)
            {
                Console .WriteLine ("Total price for this order is $"+amount);
            }
            else if (amount >= 5000 && amount <=10000)
            {
                Console .WriteLine ("Total price for this order is ${0}",810*TV +450*DVD +700*MP3 );
            }
            else
            {
                Console.WriteLine("Total price for this order is ${0}", 765 * TV + 425 * DVD + 700 * MP3);
            }
        }
    }
}