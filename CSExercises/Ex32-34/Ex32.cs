using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("Enter sales for month 0:");
            //int Jan = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 1:");
            //int Feb = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 2:");
            //int Mar = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 3:");
            //int Apr = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 4:");
            //int May = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 5:");
            //int Jun = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 6:");
            //int Jul = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 7:");
            //int Aug = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 8:");
            //int Sep = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 9:");
            //int Oct = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 10:");
            //int Nov = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter sales for month 11:");
            //int Dec = Convert.ToInt32(Console.ReadLine());
            //int[] Sales = new int[12] { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

            int[] Sales = new int[12];
            for (int k = 0; k < 12; k++)
            {
                Console.WriteLine("Enter sales for month {0}:", k);
                Sales[k] = Convert.ToInt32(Console.ReadLine());
            }
            //int[] Sales = new int[12] { 7, 9, 4, 5, 2, 1, 11, 6, 3, 10, 8, 12 };
            int i, maximum = Sales[0], minimum = Sales[0],m=0,n=0;
            for (i = 1; i < Sales.Length; i++)
            {
                if (Sales[i] < minimum)
                {
                    minimum = Sales[i];
                    m=i;
                }
                if (Sales[i] > maximum)
                {
                    maximum = Sales[i];
                    n=i;
                }
            }
            Console.WriteLine("Minimum Sales month:" + m );
            Console.WriteLine("Maximum Sales month:" + n );
            double  total=0;
            for (int a = 0; a < 12; a++)
                total = total + Sales[a];
            Console.WriteLine("Average Sales:{0:0.000}",total /12);
        }
    }
}
