using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount(0.05-3.50):");
            double amount = Convert.ToDouble(Console.ReadLine());

            double[] output = new double[5];
            if (amount < 0.05 || amount > 3.50)
                Console.WriteLine("**error**");
            else
            {
                minimum_number_of_coins(amount);
                //for (int j = 0; j < 5; j++) 
                //    Console.WriteLine(output[j]);
            }
        }

        static void minimum_number_of_coins(double amount)
        {
            int AMOUNT = Convert.ToInt32(amount * 100);
            int [] coins=new int []{100,50,20,10,5};
            double [] results=new double [5];
            for (int i = 0; i < 5; i++)
            {
                if (AMOUNT / coins[i] > 0) 
                {
                    results[i] = AMOUNT / coins[i];
                    AMOUNT = AMOUNT % coins[i];
                    for (int m = 0; m < results [i ];m ++ )
                        Console.WriteLine(coins[i] + "c");
                    //Console.WriteLine(results[i] + "\t" + AMOUNT );
                }
                else
                {
                    results[i] = 0;
                    //Console.WriteLine(results[i] + "\t" + AMOUNT);
                }
            }
            //return results ;
        }
    }
}
