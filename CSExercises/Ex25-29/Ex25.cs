using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            //int i, j = 1;
            //Console.WriteLine("enter a number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(i = 1; i <= n; i++ )
            //{
            //    j = i * j;
            //}
            //Console.WriteLine("the factorial is:" + j);

            int i, j = 1;
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for( i = n; i > 0; i-- )
            {
                j = i * j;
            }
            Console.WriteLine("the factorial is:" + j);
        }
    }
}
