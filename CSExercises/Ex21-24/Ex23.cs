using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int x,i=0;
            int NUMBER = r.Next(0, 10);
            do
            {
                Console.WriteLine("Guess the Nmuber Game,input your number:");
                x = Convert.ToInt32(Console.ReadLine());
                i = i+1;
                Console.WriteLine("try again");
            } while (x != NUMBER );
            if (i<=2)
                Console.WriteLine("You are a Wizard! your attempts is:"+i );
            else if (i>2 && i<=5)
                Console.WriteLine("You are a good guess! your attempts is:" + i);
            else
                Console.WriteLine("You are lousy! your attempts is:" + i);
        }
    }
}
