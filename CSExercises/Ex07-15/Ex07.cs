using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            decimal salary, hallowance, tallowance, tincome;
            Console.Write("please input your salary:");
            salary = Convert.ToDecimal(Console.ReadLine());
            hallowance = Convert.ToDecimal(0.1*Convert.ToDouble(salary));
            tallowance = Convert.ToDecimal(0.03*Convert.ToDouble (salary));
            tincome = Convert.ToDecimal(salary + hallowance + tallowance);
            Console.WriteLine("the total income is :"+tincome );
        }
    }
}
